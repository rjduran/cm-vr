using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceAction : MonoBehaviour
{

    public GameObject cube;

    void Update()
    {
        float dist = Vector3.Distance(transform.position, cube.transform.position);

        if(dist < 2) {
            Debug.Log("Woah Woah....too close buddy");    
        } 
        else if(dist < 4) 
        {
            Debug.Log("Stop right there Mr.");    
        } 
        else if(dist < 6) 
        {
            Debug.Log("Well hello friend");    
        } 
        else if(dist < 8)
        {
            Debug.Log("Sup");
        }
        else {
            // shh
        }

    }
}
