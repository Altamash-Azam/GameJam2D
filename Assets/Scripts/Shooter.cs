using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooter : MonoBehaviour
{
    [SerializeField] Transform shootingPoint;
    [SerializeField] GameObject bullet;

    private void Update() {
        if(Mouse.current.leftButton.wasPressedThisFrame){
            Instantiate(bullet,shootingPoint.position,transform.rotation);
        }
    }    
    
}
