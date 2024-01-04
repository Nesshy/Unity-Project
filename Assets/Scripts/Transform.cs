using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
    public Vector3 rott;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rott);
    }
}
