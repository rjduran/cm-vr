using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    // Position of target (Cube B) with small offset (to avoid teleport loop)
    private Vector3 target1 = new Vector3(4f,0.6f,0f); // Cube B
    private Vector3 target2 = new Vector3(-4f, 0.6f, 0f); // Cube A

    private void OnTriggerEnter(Collider col)
    {
        //Debug.Log("trigger enter");
        Debug.Log(col.gameObject.name + " has entered " + name);

        // One Way Teleport (Cube A -> Cube B)
        // Set the position of my (Sphere) object to the target position (Cube B) 
        // when it collides with Cube A.
        //col.gameObject.transform.position = target1;

        // Two Way Teleport
        // Set the position of my (Sphere) object to one of the target positions
        // depending on which cube it collides with. 
        if (name == "Cube A") {
            col.gameObject.transform.position = target1;
        }

        if (name == "Cube B") {
            col.gameObject.transform.position = target2;
        }

    }

}
