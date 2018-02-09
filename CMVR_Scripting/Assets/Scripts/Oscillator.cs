﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour {

    public float ampX = 1.0f; // Amplitude X
    public float ampY = 1.0f; // Amplitude Y
    public float ampZ = 1.0f; // Amplitude Z

    public float speed = 3.14f; // Speed
    public float divX = 1.0f;
    public float divY = 1.0f;
    public float divZ = 1.0f;

    public bool toggleX, toggleY, toggleZ;
    public bool makeLittle;

    private Vector3 startPos;
    private Vector3 startScale;

    void Start()
    {
        startPos = transform.position; // get current position
        startScale = transform.localScale; //  get current scale
        toggleX = true;
        toggleY = false;
        toggleZ = false;
        makeLittle = false;
        divX = 1.0f;
        divY = 1.0f;
        divZ = 1.0f;
    }

    void Update()
    {

        Vector3 v = startPos; // get starting position
        Vector3 s = startScale;

        if (makeLittle)
        {
            s *= 0.5f;
            transform.localScale = s;
            //makeLittle = false;
        } else {
            transform.localScale = s;
        }

        if (toggleX)
        {
            v.x += ampX * Mathf.Sin(Time.time * speed/divX);
        }
        if (toggleY)
        {
            v.y += ampY * Mathf.Sin(Time.time * speed/divY);
        }
        if (toggleZ)
        {
            v.z += ampZ * Mathf.Sin(Time.time * speed/divZ);
        }

        transform.position = v; //  update the position





    }
}
