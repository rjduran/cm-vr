using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour {

    public GameObject cube;
    		
	void Update () {
        float dist = Vector3.Distance(transform.position, cube.transform.position);
        Debug.Log(dist);
		
	}
}
