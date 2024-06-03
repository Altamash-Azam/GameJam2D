using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    Score score;
    [SerializeField] int HP;
    [SerializeField] bool isPlayer = false;

    private void Start() {
        score = FindObjectOfType<Score>();
    }
    public void takeDamage(){
        HP -= 100;
        if(HP == 0){
            score.updateScore(500);
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
