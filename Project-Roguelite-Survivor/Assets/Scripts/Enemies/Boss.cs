using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boss : MonoBehaviour
{
    public GameObject TheBoss;
    public int BossHealth = 2500;
    public GameObject ExpDrop;
    public int shotgunBulletDMG = 25;

    public GameObject BossShot;
    public GameObject BossSlam;
    public GameObject BossFire;
    public GameObject BossRage;
    public float fireRate = 6f;
    private float lastShot = 0.0f;
    public float fireRateB = 14f;
    private float lastShotB = 0.0f;
    public float fireRateC = 4f;
    private float lastShotC = 0.0f;

    private bool Stage1 = true;
    private bool Stage2 = true;
    private bool Stage3 = true; 
    private bool Stage4 = true;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Abilities());
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 BossPos = TheBoss.transform.position;


        if (Time.time > fireRate + lastShot)
        {

            Instantiate(BossShot, BossPos + new Vector3(0f, +0.05f, 0f), Quaternion.identity);

            lastShot = Time.time;
        }

        if (Time.time > fireRateB + lastShotB)
        {

            Instantiate(BossSlam, BossPos - new Vector3(0f, 0f, 0.5f), Quaternion.identity);

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

    IEnumerator BossRaging()
    {
        while (true)
        {
            if (Time.time > fireRateC + lastShotC)
            {
                Vector3 tankPos = TheBoss.transform.position;
                Instantiate(BossRage, tankPos, Quaternion.identity);

                lastShotC = Time.time;
            }
            yield return null;
        }

    }

        IEnumerator Abilities()
    {
        
        while (Stage1 == true)
        {
            if (BossHealth <= 2000)
                {
                Vector3 gunPos = TheBoss.transform.position;
                (Instantiate(BossFire, gunPos, Quaternion.identity) as GameObject).transform.parent = TheBoss.transform;
                GetComponent<NavMeshAgent>().speed = 0.25f;
                Stage1 = false;
                }
            yield return null;
        }
        while (Stage2 == true)
        {
            if (BossHealth <= 1500)
            {
                fireRate = 4f;
                fireRateB = 12f;
                GetComponent<NavMeshAgent>().speed = 0.35f;
                Stage2 = false;
            }
            yield return null;
        }
        while (Stage3 == true)
        {
            if (BossHealth <= 1000)
            {
                fireRate = 2f;
                fireRateB = 8f;
                GetComponent<NavMeshAgent>().speed = 0.50f;
                Stage3 = false;
            }
            yield return null;
        }
        while (Stage4 == true)
        {
            if (BossHealth <= 500)
            {
                StartCoroutine(BossRaging());
                fireRate = 0.8f;
                fireRateB = 6f;
                Stage4 = false;
            }
            yield return null;
        }
        
    }
}
