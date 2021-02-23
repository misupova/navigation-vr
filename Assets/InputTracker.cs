using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class InputTracker : MonoBehaviour
{
    // Time interval for movement recording
    public int frameInterfal = 4;

    string getFolderPath()
    {
        string path = Application.dataPath;
        path = Path.Combine(path, "MovementLogs");

        // Create log directory if doesn't exist
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);

        return path;
    }

    public class Movement
    {
        public Vector3 position;
        public float time, distance;

        //default constructor
        public Movement()
        {
            this.position = Vector3.zero;
            this.time = 0f;
            this.distance = 0f;
        }
        public Movement(Vector3 position)
        {
            this.position = position;
            this.time = Time.timeSinceLevelLoad;
        }

        public void setDistance(float distance)
        {
            this.distance = distance;
        }

    }


    List<Movement> movements = new List<Movement>();
    // Start is called before the first frame update
    void Start()
    {
        Transform playerTrans = this.transform;
        Transform camera = playerTrans.Find("FirstPersonCharacter");

        Debug.Log(getFolderPath());
    }

    int timer = 0;
    Transform cameraTransform;
    int currentMovementIndex = 0;
    bool levelCompleted = false;
    // Update is called once per frame
    void Update()
    {
        if (timer % frameInterfal == 0)
        {
            if (!levelCompleted)
            {
                cameraTransform = Camera.main.transform;
                movements.Add(new Movement(cameraTransform.position));
                currentMovementIndex++;
            }
        }
        timer++;

    }

    IEnumerator OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");

        // If goal was triggered stop recording
        if (!other.CompareTag("GoalTrigger") || levelCompleted) yield break;

        levelCompleted = true;

        // Calculate travelled distance

        for (int i = 0; i < movements.Count; i++)
        {
            if (i == 0)
            {
                movements[i].setDistance(0f);
            }
            else
            {
                movements[i].setDistance(Vector3.Distance(movements[i].position, movements[i-1].position));
            }
        }

        XmlSerializer serialiser = new XmlSerializer(typeof(List<Movement>));

        // Create the TextWriter for the serialiser to use
        TextWriter filestream = new StreamWriter(Path.Combine(getFolderPath(), "test.xml"));

        //write to the file
        serialiser.Serialize(filestream, movements);

        // Close the file
        filestream.Close();
    }
}

