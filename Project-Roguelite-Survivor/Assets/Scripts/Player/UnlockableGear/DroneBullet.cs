using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneBullet : MonoBehaviour
{
    public GameObject Drone;
    public int droneBulletPen = 2;
    public static float bulletVelocity = 2.0f;


    void OnBecameInvisible()
    {
        Debug.Log("Invisible Drone Bullet");
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Drone = GameObject.FindWithTag("Drone");
        transform.rotation = Drone.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletVelocity * Time.deltaTime;
        if (droneBulletPen <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "Charger")
        {

            droneBulletPen--;
        }
        else if (targetObj.gameObject.tag == "Swarmer")
        {

            droneBulletPen -= 2;
        }
        else if (targetObj.gameObject.tag == "Sponge")
        {

            droneBulletPen -= 4;
        }
        else if (targetObj.gameObject.tag == "Boss")
        {
            droneBulletPen -= 8;
        }

    }
}

