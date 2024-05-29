using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    void Update()
    {
        flip();
        Move();
    }
    public void Move(){
        if (Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0.003f,0.004f,0);
        }
        else if(Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(-0.003f,-0.004f,0);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.position += new Vector3(0.004f,0,0); 
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(-0.004f,0,0);
        }
    }
    void flip(){
        if(Input.GetKey(KeyCode.D)){
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        if(Input.GetKey(KeyCode.A)){
            transform.rotation = Quaternion.Euler(0,180,0);
        }
    }
}
