using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointMovement : MonoBehaviour
{
    public GameObject[] waypoints;
    int currentWaypointIndex = 0;
    public float speed = 1.0f;

    void Start()  // Start is called before the first frame update
    {
        
    }


    void Update()  // Update is called once per frame
    {
        if(Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < .1f)
        {
            currentWaypointIndex++;
            if(currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }  
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime);
    }
}
