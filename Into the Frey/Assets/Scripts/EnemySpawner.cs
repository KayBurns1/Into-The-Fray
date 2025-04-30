using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject meleeSwarmer;
    [SerializeField]
    private GameObject rangedSwarmer;

    //how long it takes for the enemy to spawn
    [SerializeField]
    private float meleeSwarmerInterval = 3.5f;
    [SerializeField]
    private float rangedSwarmerInterval = 5f;
    
    //countdown timer to increase spawning interval
    private float countdown = 5f;
    private float count = 0;


    //calling script so we can access the bool to start spawning
    //public BarFightScene bfs;
    //public bool fight = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(meleeSwarmerInterval, meleeSwarmer));
        StartCoroutine(spawnEnemy(rangedSwarmerInterval, rangedSwarmer));
    }

    private void Update()
    {
        //makes sure the enemies spawn only after player does dialogue scene
        /*if (bfs.dialogueCompleted)
        {
            bfs.dialogueCompleted = false;
            fight = true;
            //start spawning
            StartCoroutine(spawnEnemy(meleeSwarmerInterval, meleeSwarmer));
            StartCoroutine(spawnEnemy(rangedSwarmerInterval, rangedSwarmer));
        }*/

        /*while (fight)
        {*/
            //keep increasing count var while fighting is happening
            count += Time.deltaTime;

            //decease spawning interval to make enemies spawn faster when count is equal to countdown
            if (count >= countdown)
            {
                meleeSwarmerInterval = Mathf.Max(0.5f, meleeSwarmerInterval - 0.1f);
                rangedSwarmerInterval = Mathf.Max(0.5f, rangedSwarmerInterval - 0.1f);

                count = 0;
            }
        //}
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        //how long it takes before spawning a new enemy
        yield return new WaitForSeconds(interval);
        //actually spawning the enemy within a random range
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-4f, 4), Random.Range(-6f, 6), 0), Quaternion.identity);
        //endless but change to counter if we wanted it to end at some point
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
