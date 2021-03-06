﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class tow_aqua_move : MonoBehaviour
{
    public Rigidbody rb;
    public int speed;
    public Transform towPosition;
    public Vector3 start_pos;
    public Vector3 current;

    // Start is called before the first frame update
    void Start()
    {
        start_pos = towPosition.position;
        speed = 5;
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, -speed);
    }
    void Update()
    {   
        rb.velocity = new Vector3(0, 0, -speed);
        current = towPosition.position;
        if (current.z < -50.0) {
            Debug.Log("Out Of Bound");
            towPosition.position = start_pos;
        }
    }
}
