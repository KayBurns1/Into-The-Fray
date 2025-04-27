using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //enemy objects
    [SerializeField]
    private GameObject swordSwarmer;
    [SerializeField]
    private GameObject rangedSwarmer;

    //how long it takes for the enemy to spawn
    [SerializeField]
    private float swordSwarmerInterval = 10f;
    [SerializeField]
    private float rangedSwarmerInterval = 15f;

    //countdown timer to increase spawning interval
    private float countdown = 30f;
    private float count = 0;


    //calling script so we can access the bool to start spawning
    public BarFightScene bfs;
    public bool fight = false;

    // Start is called before the first frame update
    void Start()
    {
        //set the spawning interval to 10 and 15
        swordSwarmerInterval = 10f;
        rangedSwarmerInterval = 15f;
    }

    private void Update()
    {
        //makes sure the enemies spawn only after player does dialogue scene
        if (bfs.dialogueCompleted)
        {
            bfs.dialogueCompleted = false;
            fight = true;
            //start spawning
            StartCoroutine(spawnEnemy(swordSwarmerInterval, swordSwarmer));
            StartCoroutine(spawnEnemy(rangedSwarmerInterval, rangedSwarmer));
        }

        while (fight)
        {
            //keep increasing count var while fighting is happening
            count += Time.deltaTime;

            //decease spawning interval to make enemies spawn faster when count is equal to countdown
            if (count >= countdown)
            {
                swordSwarmerInterval -= .1f;
                rangedSwarmerInterval -= .1f;
                count = 0;
            }
        }

    }

    //coroutine to continuously spawn enemies
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
