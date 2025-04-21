using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject swordSwarmer;
    [SerializeField]
    private GameObject rangedSwarmer;

    //how long it takes for the enemy to spawn
    [SerializeField]
    private float swordSwarmerInterval = 3.5f;
    [SerializeField]
    private float rangedSwarmerInterval = 5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(swordSwarmerInterval, swordSwarmer));
        StartCoroutine(spawnEnemy(rangedSwarmerInterval, rangedSwarmer));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        //how long it takes before spawning a new enemy
        yield return new WaitForSeconds(interval);
        //actually spawning the enemy within a random range
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6), 0), Quaternion.identity);
        //endless but change to counter if we wanted it to end at some point
        StartCoroutine(spawnEnemy(interval, newEnemy));
    }
}
