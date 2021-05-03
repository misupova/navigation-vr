using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedirectionTest : MonoBehaviour
{
    private const float S2O_TARGET_GENERATION_ANGLE_IN_DEGREES = 60;

    public float S2O_TARGET_RADIUS = 5.0f; //Target orbit radius for Steer-to-Orbit algorithm (meters)

    public Transform trackedSpace;

    public Transform headTransform;

    [HideInInspector]
    public Vector3

            currPos,
            currPosReal,
            prevPos,
            prevPosReal;

    [HideInInspector]
    public Vector3

            currDir,
            currDirReal,
            prevDir,
            prevDirReal;

    // User Experience Improvement Parameters
    private const float MOVEMENT_THRESHOLD = 0.2f; // meters per second

    private const float ROTATION_THRESHOLD = 1.5f; // degrees per second

    private const float CURVATURE_GAIN_CAP_DEGREES_PER_SECOND = 15; // degrees per second

    private const float ROTATION_GAIN_CAP_DEGREES_PER_SECOND = 30; // degrees per second

    private const float DISTANCE_THRESHOLD_FOR_DAMPENING = 1.25f; // Distance threshold to apply dampening (meters)

    private const float BEARING_THRESHOLD_FOR_DAMPENING = 45f; // TIMOFEY: 45.0f; // Bearing threshold to apply dampening (degrees) MAHDI: WHERE DID THIS VALUE COME FROM?

    private const float SMOOTHING_FACTOR = 0.125f; // Smoothing factor for redirection rotations

    protected bool noTmpTarget = true;

    protected Transform currentTarget; //Where the participant  is currently directed?

    protected GameObject tmpTarget;

    private float rotationFromCurvatureGain; //Proposed curvature gain based on user speed

    private float rotationFromRotationGain; //Proposed rotation gain based on head's yaw

    private float lastRotationApplied = 0f;

    Vector3 deltaPos;

    float deltaDir;

    [Tooltip("Radius applied by curvature gain")]
    [Range(1, 23)]
    public float CURVATURE_RADIUS = 7.5F;

    [Tooltip("Maximum rotation gain applied")]
    [Range(0, 5)]
    public float MAX_ROT_GAIN = 0.49F;

    [Tooltip("Minimum rotation gain applied")]
    [Range(-0.99F, 0)]
    public float MIN_ROT_GAIN = -0.2F;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        currPos = FlattenedPos3D(headTransform.position);
        currDir = FlattenedDir3D(headTransform.forward);
        Vector3 trackingAreaPosition = FlattenedPos3D(trackedSpace.position);
        Vector3 userToCenter = trackingAreaPosition - currPos;

        if (noTmpTarget)
        {
            tmpTarget = new GameObject("S2O Target");
            currentTarget = tmpTarget.transform;
            noTmpTarget = false;
        }

        float alpha;

        //Where is user relative to desired orbit?
        if (
            userToCenter.magnitude < S2O_TARGET_RADIUS //Inside the orbit
        )
        {
            alpha = S2O_TARGET_GENERATION_ANGLE_IN_DEGREES;
        }
        else
        {
            //Use tangents of desired orbit
            alpha = Mathf.Acos(S2O_TARGET_RADIUS / userToCenter.magnitude) * Mathf.Rad2Deg;
        }
        Vector3 dir1 = Quaternion.Euler(0, alpha, 0) * -userToCenter.normalized;
        Vector3 targetPosition1 = trackingAreaPosition + S2O_TARGET_RADIUS * dir1;
        Vector3 dir2 = Quaternion.Euler(0, -alpha, 0) * -userToCenter.normalized;
        Vector3 targetPosition2 = trackingAreaPosition + S2O_TARGET_RADIUS * dir2;

        //Step Three: Evaluate difference in direction
        // We don't care about angle sign here
        float angle1 = Vector3.Angle(currDir, targetPosition1 - currPos);
        float angle2 = Vector3.Angle(currDir, targetPosition2 - currPos);

        currentTarget.transform.position = (angle1 <= angle2) ? targetPosition1 : targetPosition2;

        CalculateStateChanges();

        rotationFromCurvatureGain = 0;

        if (
            deltaPos.magnitude / GetDeltaTime() > MOVEMENT_THRESHOLD //User is moving
        )
        {
            rotationFromCurvatureGain = Mathf.Rad2Deg * (deltaPos.magnitude / CURVATURE_RADIUS);
            rotationFromCurvatureGain =
                Mathf.Min(rotationFromCurvatureGain, CURVATURE_GAIN_CAP_DEGREES_PER_SECOND * GetDeltaTime());
        }

        //Compute desired facing vector for redirection
        Vector3 desiredFacingDirection = FlattenedPos3D(currentTarget.position) - currPos;
        int desiredSteeringDirection = (-1) * (int) Mathf.Sign(GetSignedAngle(currDir, desiredFacingDirection)); // We have to steer to the opposite direction so when the user counters this steering, she steers in right direction

        //Compute proposed rotation gain
        rotationFromRotationGain = 0;

        if (
            Mathf.Abs(deltaDir) / GetDeltaTime() >= ROTATION_THRESHOLD //if User is rotating
        )
        {
            //Determine if we need to rotate with or against the user
            if (deltaDir * desiredSteeringDirection < 0)
            {
                //Rotating against the user
                rotationFromRotationGain =
                    Mathf
                        .Min(Mathf.Abs(deltaDir * MIN_ROT_GAIN), ROTATION_GAIN_CAP_DEGREES_PER_SECOND * GetDeltaTime());
            }
            else
            {
                //Rotating with the user
                rotationFromRotationGain =
                    Mathf
                        .Min(Mathf.Abs(deltaDir * MAX_ROT_GAIN), ROTATION_GAIN_CAP_DEGREES_PER_SECOND * GetDeltaTime());
            }
        }

        float rotationProposed =
            desiredSteeringDirection * Mathf.Max(rotationFromRotationGain, rotationFromCurvatureGain);
        bool curvatureGainUsed = rotationFromCurvatureGain > rotationFromRotationGain;

        Debug.Log (rotationProposed);

        // Prevent having gains if user is stationary
        if (Mathf.Approximately(rotationProposed, 0)) return;

        //DAMPENING METHODS
        // MAHDI: Sinusiodally scaling the rotation when the bearing is near zero
        float bearingToTarget = Vector3.Angle(currDir, desiredFacingDirection);

        // MAHDI
        // The algorithm first is explained to be similar to above but at the end it is explained like this. Also the BEARING_THRESHOLD_FOR_DAMPENING value was never mentioned which make me want to use the following even more.
        rotationProposed *= Mathf.Sin(Mathf.Deg2Rad * bearingToTarget);

        // MAHDI: Linearly scaling the rotation when the distance is near zero
        if (desiredFacingDirection.magnitude <= DISTANCE_THRESHOLD_FOR_DAMPENING)
        {
            rotationProposed *= desiredFacingDirection.magnitude / DISTANCE_THRESHOLD_FOR_DAMPENING;
        }

        float finalRotation = (1.0f - SMOOTHING_FACTOR) * lastRotationApplied + SMOOTHING_FACTOR * rotationProposed;
        lastRotationApplied = finalRotation;

        // transform.RotateAround(headTransform.position, Vector3.up, 20 * Time.deltaTime);

        transform.RotateAround(FlattenedPos3D(headTransform.position), Vector3.up, finalRotation);

        UpdatePreviousUserState();
    }

    void UpdatePreviousUserState()
    {
        prevPos = FlattenedPos3D(headTransform.position);
        prevPosReal = GetRelativePosition(prevPos, this.transform);
        prevDir = FlattenedDir3D(headTransform.forward);
        prevDirReal = FlattenedDir3D(GetRelativeDirection(prevDir, this.transform));
    }

    void CalculateStateChanges()
    {
        deltaPos = currPos - prevPos;
        deltaDir = GetSignedAngle(prevDir, currDir);
    }

    public float GetDeltaTime()
    {
        return Time.deltaTime;
    }

    public static float GetSignedAngle(Vector3 prevDir, Vector3 currDir)
    {
        return Mathf.Sign(Vector3.Cross(prevDir, currDir).y) * Vector3.Angle(prevDir, currDir);
    }

    public static Vector3 GetRelativeDirection(Vector3 dir, Transform origin)
    {
        return Quaternion.Inverse(origin.rotation) * dir;
    }

    private Vector3 FlattenedPos3D(Vector3 vec, float height = 0)
    {
        return new Vector3(vec.x, height, vec.z);
    }

    public static Vector3 FlattenedDir3D(Vector3 vec)
    {
        return (new Vector3(vec.x, 0, vec.z)).normalized;
    }

    public static Vector3 GetRelativePosition(Vector3 pos, Transform origin)
    {
        return Quaternion.Inverse(origin.rotation) * (pos - origin.position);
    }
}
