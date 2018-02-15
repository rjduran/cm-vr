using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterTarget : MonoBehaviour
{
    // Target gameobject (position)
    public GameObject target;

    private void OnTriggerEnter(Collider col)
    {
        //Debug.Log("trigger enter");
        Debug.Log(col.gameObject.name + " has entered " + name);

        // One Way Teleport (current position -> target position)
        col.gameObject.transform.position = target.gameObject.transform.position;
    }

}
