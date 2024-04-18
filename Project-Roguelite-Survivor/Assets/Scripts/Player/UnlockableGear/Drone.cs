using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone : MonoBehaviour
{
    public GameObject droneBullet;
    public float fireRate = 0.5f;
    private float lastShot = 0.0f;

    public GameObject DroneObj;
    // Start is called before the first frame update
    void Start()
    {
        DroneObj = GameObject.FindWithTag("Drone");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dronePos = DroneObj.transform.position;

        if (Input.GetMouseButton(1))
        {
            if (Time.time > fireRate + lastShot)
            {

                Instantiate(droneBullet, dronePos, Quaternion.identity);

                lastShot = Time.time;
            }
        }
    }
}
