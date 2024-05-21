using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunBullet : MonoBehaviour
{
    public GameObject Player;
    public int shotgunBulletPen = 5;
    public static float bulletVelocity = 4.0f;
    public GameObject Feedback;
    Vector3 areaZero;

    void OnBecameInvisible()
    {

        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        transform.rotation = Player.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        areaZero = gameObject.transform.position;
        transform.position += transform.forward * bulletVelocity * Time.deltaTime;
        if (shotgunBulletPen <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "Charger")
        {
            shotgunBulletPen--;
        }
        else if (targetObj.gameObject.tag == "Swarmer")
        {
            shotgunBulletPen -= 2;
        }
        else if (targetObj.gameObject.tag == "Sponge")
        {
            shotgunBulletPen -= 4;
        }
        else if (targetObj.gameObject.tag == "Boss")
        {
            shotgunBulletPen -= 8;
        }
        if (targetObj.gameObject.tag == "Player")
        {
            Debug.Log("Player");
        }
        else if (targetObj.gameObject.tag == "CollectRadius")
        {
            Debug.Log("CollectRadius");
        }
        else
        {
            Instantiate(Feedback, areaZero, Quaternion.identity);
        }
    }
}

