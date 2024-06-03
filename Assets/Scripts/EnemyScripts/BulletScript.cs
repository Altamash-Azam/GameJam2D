using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletScript : MonoBehaviour
{
    GameObject target;
    public float speed;
    Rigidbody2D bulletRB;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player");
        Vector2 moveDir = (target.transform.position - transform.position).normalized * speed;
        bulletRB.velocity = new Vector2(moveDir.x,moveDir.y);
        Destroy(this.gameObject,2);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
