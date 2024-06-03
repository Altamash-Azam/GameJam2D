using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] float spawnRate = 1f;
    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] bool canSpawn = true;
    private Score points;

    private void Start()
    {
        StartCoroutine(Spawner());
        points = GetComponent<Score>();
        
    }

    private void Update()
    {
        if(points.score == 5000)
        {
            canSpawn = false;
        }
    }

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(spawnRate);
        while(canSpawn)
        {
            yield return wait;
            int rand = Random.Range(0 , enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[rand];

            Instantiate(enemyToSpawn, transform.position ,Quaternion.identity);
        }
    }

}
