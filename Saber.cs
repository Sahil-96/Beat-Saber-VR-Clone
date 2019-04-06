using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script performs the hit collision between the light saber and the cubes

public class Saber : MonoBehaviour
{
    public LayerMask layer;
    private Vector3 previousPos;

    // Update is called once per frame
    void Update()
    {
        //This could all have been done with the box collider

        RaycastHit hit; 
   
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer)) // this conditional can return two values 1. if the raycast hit something, and what it hit
        {
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130) // this checks if the players swing is coming from the correct direction 
            {
                Destroy(hit.transform.gameObject);
            }
        }
        previousPos = transform.position; 
    }
}
