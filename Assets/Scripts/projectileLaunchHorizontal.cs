using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileLaunchHorizontal : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform launchPoint;

    private Camera mainCam;
    private Vector3 mousePos;

    public float shootTime;
    public float shootCounter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        shootCounter = shootTime;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 rotation = mousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if(Input.GetMouseButtonDown(0) && shootCounter <=0)
        {
            Instantiate(projectilePrefab, launchPoint.position, Quaternion.identity);
            shootCounter = shootTime;
        }
        shootCounter -= Time.deltaTime;
    }
}
