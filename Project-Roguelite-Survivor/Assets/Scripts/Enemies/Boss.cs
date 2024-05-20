using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject TheBoss;
    public int BossHealth = 1000;
    public GameObject ExpDrop;
    public Vector3 BossPos;
    public int shotgunBulletDMG = 25;

    public GameObject BossShot;
    public GameObject BossSlam;
    public float fireRate = 6f;
    private float lastShot = 0.0f;
    public float fireRateB = 14f;
    private float lastShotB = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BossPos = TheBoss.transform.position;

        Vector3 gunPos = TheBoss.transform.position;


        if (Time.time > fireRate + lastShot)
        {

            Instantiate(BossShot, gunPos + new Vector3(0f, +0.05f, 0f), Quaternion.identity);

            lastShot = Time.time;
        }

        if (Time.time > fireRateB + lastShotB)
        {

            Instantiate(BossSlam, gunPos - new Vector3(0f, 0f, 0.5f), Quaternion.identity);

            lastShotB = Time.time;
        }
    }

    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "ShotgunBullet")
        {
            BossHealth -= shotgunBulletDMG;
            if (BossHealth <= 0)
            {
                TheBoss.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "NadeExplosion")
        {
            BossHealth -= 100;
            if (BossHealth <= 0)
            {
                TheBoss.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "DroneBullet")
        {
            BossHealth -= 8;
            if (BossHealth <= 0)
            {
                TheBoss.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "DroneExplosion")
        {
            BossHealth -= 75;
            if (BossHealth <= 0)
            {
                TheBoss.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
    }

}
