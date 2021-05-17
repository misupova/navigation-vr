// ShowGoldenPath
using UnityEngine;
using UnityEngine.AI;

public class ShowGoldenPath : MonoBehaviour
{
    public Transform target;
    private NavMeshPath path;
    private NavMeshAgent agent;
    
    private float elapsed = 0.0f;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
        elapsed = 0.0f;
        NavMesh.CalculatePath(transform.position, target.position, NavMesh.AllAreas, path);
        agent.SetPath(path);
    }

    void Update()
    {
    //     // Update the way to the goal every second.
    //     elapsed += Time.deltaTime;
    //     if (elapsed > 1.0f)
    //     {
    //         elapsed -= 1.0f;
            
    //     }
    //     for (int i = 0; i < path.corners.Length - 1; i++)
            
    //         Debug.DrawLine(path.corners[i], path.corners[i + 1], Color.red,2, false);
    }
}