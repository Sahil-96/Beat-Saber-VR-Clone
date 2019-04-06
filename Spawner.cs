using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this script will spawn the cubes to break by the sabers based on the BMP of the preselected song

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes; // an array to hold all the cube game objects
    public Transform[] points; // an array of possible spawning locations for the cubes
    public float beat = (60/105)*2; // the point in time when the cubes spawn
    private float timer; // a variable the will count up as the song progresses. 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > beat) // if the counter has reached the beat in the song, a cube will spawn
        {
            GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0,4)]); // spawn cube at semi random location 
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0,4)); // random rotation
            timer -= beat; // reset the timer
        }

        timer += Time.deltaTime;
    }
}
