using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BombDrone : MonoBehaviour
{
    public static float droneSpeed = 1.0f;
    public GameObject droneExplosion;
    Vector3 areaZero;

    void OnBecameInvisible()
    {

        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * droneSpeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag == "Charger")
        {
            areaZero = gameObject.transform.position;
            Instantiate(droneExplosion, areaZero, Quaternion.identity);
            Destroy(gameObject);
        }
        if (targetObj.gameObject.tag == "Swarmer")
        {
            areaZero = gameObject.transform.position;
            Instantiate(droneExplosion, areaZero, Quaternion.identity);
            Destroy(gameObject);
        }
        if (targetObj.gameObject.tag == "Sponge")
        {
            areaZero = gameObject.transform.position;
            Instantiate(droneExplosion, areaZero, Quaternion.identity);
            Destroy(gameObject);
        }
        if (targetObj.gameObject.tag == "Boss")
        {
            areaZero = gameObject.transform.position;
            Instantiate(droneExplosion, areaZero, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
