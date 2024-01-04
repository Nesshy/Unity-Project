using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidB : MonoBehaviour
{
    public Vector3 pozisyon;
    public Rigidbody rbody;
    public Vector3 hiz;
    void Start()
    {
        pozisyon = new Vector3 (1,1,1);
        hiz= new Vector3 (1,1,1);
    }

    // Update is called once per frame
    void Update()
    {
        rbody.MovePosition(pozisyon);
        rbody.velocity = hiz*100;
    }
}
