using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject[] Waypoints;
    public int waypointindex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Waypoints[waypointindex].transform.position, 0.01f);
        if (Vector3.Distance(transform.position, Waypoints[waypointindex].transform.position)<=0.0001f);
        {
            if (waypointindex>0)
            {
                waypointindex = 0;
            }
            else
            {
                waypointindex++;
            }

        } 
        
    }
}
