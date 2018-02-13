using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterRandom : MonoBehaviour {

    private float rand;
    private Vector3[] pos;

	// Use this for initialization
	void Start () {     
        // Define the size of the array before putting values into it
        pos = new Vector3[4];

        // Fill array with Vector3 objects
        pos[0] = new Vector3(-3f, 0.6f, 0f); // Cube A
        pos[1] = new Vector3(3f, 0.6f, 0f); // Cube B
        pos[2] = new Vector3(0f, 0.6f, 3f); // Cube C
        pos[3] = new Vector3(0f, 0.6f, -3f); // Cube D
        		
	}
	
    private void OnTriggerEnter(Collider col)
    {
        //Debug.Log("trigger enter");
        Debug.Log(col.gameObject.name + " has entered " + name);

        rand = Random.Range(0, pos.Length);
        //Debug.Log(rand); // Print out the random number
        //Debug.Log(pos[(int)rand]); // Print out the value of pos

        // Set the position of the Sphere
        col.gameObject.transform.position = pos[(int)rand];
    }
}
