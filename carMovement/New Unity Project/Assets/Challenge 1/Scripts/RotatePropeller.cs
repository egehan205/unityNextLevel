﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropeller : MonoBehaviour {
    // Start is called before the first frame update

    private float turnSpeed = 500.0f;
    void Start () {

    }

    // Update is called once per frame
    void Update () {

        transform.Rotate (Vector3.forward, Time.deltaTime * turnSpeed);

    }
}