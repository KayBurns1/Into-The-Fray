using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileLaunchHorizontal : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform launchPoint;

    public float shootTime;
    public float shootCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootCounter = shootTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && shootCounter <=0)
        {
            Instantiate(projectilePrefab, launchPoint.position, Quaternion.identity);
            shootCounter = shootTime;
        }
        shootCounter -= Time.deltaTime;
    }
}
