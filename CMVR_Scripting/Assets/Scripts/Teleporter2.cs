using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter2 : MonoBehaviour
{

    // Position of target (Cube B) with small offset (to avoid teleport loop)
    private Vector3 target2 = new Vector3(-4f, 0.6f, 0f); // Cube A
    private Vector3 target1 = new Vector3(4f, 0.6f, 0f); // Cube B
    private Vector3 target3 = new Vector3(0f, 0.6f, 4f); // Cube C
    private Vector3 target4 = new Vector3(0f, 0.6f, -4f); // Cube D

    private void OnTriggerEnter(Collider col)
    {
        //Debug.Log("trigger enter");
        Debug.Log(col.gameObject.name + " has entered " + name);

        if (name == "Cube A")
        {
            col.gameObject.transform.position = target1;
        }

        if (name == "Cube B")
        {
            col.gameObject.transform.position = target2;
        }

        if (name == "Cube C")
        {
            col.gameObject.transform.position = target4;
        }

        if (name == "Cube D")
        {
            col.gameObject.transform.position = target3;
        }

    }

}
