using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyFollowPlayer : MonoBehaviour
{
    [SerializeField] float speed;
    public float lignOfSight;
    public float shootingRange;
    public GameObject bullet;
    public GameObject bulletParent;
    public float fireRate = 1f;
    private float nextFireTime;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceFromPlayer = Vector2.Distance(player.position, transform.position);
        if(distanceFromPlayer < lignOfSight && distanceFromPlayer > shootingRange)
        {
            transform.position = Vector2.MoveTowards(this.transform.position,player.position, speed * Time.deltaTime);
        }
        else if(distanceFromPlayer <= shootingRange && nextFireTime < Time.time)
        {
            Instantiate(bullet,bulletParent.transform.position,Quaternion.identity);
            nextFireTime = Time.time + fireRate;
        }
    }

    void OnDrawGizmos() 
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lignOfSight);
        Gizmos.DrawWireSphere(transform.position, shootingRange);
    }
}
