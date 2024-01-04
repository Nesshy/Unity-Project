using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vektor : MonoBehaviour
{
    Vector2 vec,vec2,son;
    void Start()
    {
        vec= new Vector2(5,3);
        vec2= new Vector2(5,7);
        son = vec + vec2;
        print(son);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
