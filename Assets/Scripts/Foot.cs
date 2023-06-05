using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot : MonoBehaviour
{
    public CharMove Movement;

    void Start()
    {

     Movement = GetComponent<CharMove>();

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Console.WriteLine("Colidiu");
        if(other.gameObject.tag == "Ground")
        {
            Movement.JumpQtd = 2;
        }
        if(other.gameObject.tag == "DieLine")
        {

        }
    }

}
