﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotatorFastest : MonoBehaviour
{
    float orbitSpeed = .4f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, orbitSpeed, 0));
    }
}