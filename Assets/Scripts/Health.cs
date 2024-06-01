using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int HP;

    public void takeDamage(){
        HP -= 100;
        if(HP == 0){
            Destroy(gameObject);
        }
        Debug.Log("callled" + HP);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Bullet"){
            takeDamage();
        }
    }
}
