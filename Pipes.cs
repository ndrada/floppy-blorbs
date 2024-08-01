using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float moveSpeed = 5; //speed of the pipes
    public float deadZone = -45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; //moves the pipes to the left

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject); //destroys the game object when it reaches the dead zone
            Debug.Log("Pipe Deleted"); //logs the pipe deletion
        }


    }
}
