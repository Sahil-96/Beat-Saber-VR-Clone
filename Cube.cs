using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this is a basic script that just moves the breakable cubes from the spawner area towards the player 

public class Cube : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * 2 * transform.forward; //the *2 is because it then matchs the BPM and the beats counter in spawner script
    }
}
