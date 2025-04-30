using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class projectileLaunchHorizontal : MonoBehaviour
 {
     public GameObject projectilePrefab;
     public Transform launchPoint;
 
     private Camera mainCam;
 
     public float shootTime;
     public float shootCounter;
 
     // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
     {
         mainCam = Camera.main;
         shootCounter = 0;
     }
 
     // Update is called once per frame
     void Update()
     {
        shootCounter -= Time.deltaTime;

         if(Input.GetMouseButtonDown(0) && shootCounter <=0)
         {
            Vector3 mouseWorldPos = mainCam.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mouseWorldPos - launchPoint.position;
            direction.Normalize();

            //spawn and direct the projectile
            GameObject proj = Instantiate(projectilePrefab, launchPoint.position, Quaternion.identity);
            proj.GetComponent<Projectile>().SetDirection(direction);

            shootCounter = shootTime;
         }
     }
 }