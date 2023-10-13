using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    private Vector3 dist_to_player;
    // Start is called before the first frame update
    void Start()
    {
        dist_to_player = player.transform.position - transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position - dist_to_player;
        
    } 
}
