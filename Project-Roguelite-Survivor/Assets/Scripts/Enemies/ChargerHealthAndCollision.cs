using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChargerHealthAndCollision : MonoBehaviour
{
    public GameObject Charger;
    public int ChargerHealth = 30;
    public GameObject ExpDrop;
    public Vector3 ChargerPos;
    public int shotgunBulletDMG = 25;
    public int rifleBulletDMG = 10;

    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "ShotgunBullet")
        {
            ChargerHealth -= shotgunBulletDMG;
            if (ChargerHealth <= 0)
            {
                Instantiate(ExpDrop, ChargerPos, Quaternion.identity);
                Instantiate(ExpDrop, ChargerPos, Quaternion.identity);
                Charger.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "RifleBullet")
        {
            ChargerHealth -= rifleBulletDMG;
            if (ChargerHealth <= 0)
            {
                Instantiate(ExpDrop, ChargerPos, Quaternion.identity);
                Instantiate(ExpDrop, ChargerPos, Quaternion.identity);
                Charger.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "NadeExplosion")
        {
            ChargerHealth -= 100;
            if (ChargerHealth <= 0)
            {
                Instantiate(ExpDrop, ChargerPos, Quaternion.identity);
                Instantiate(ExpDrop, ChargerPos, Quaternion.identity);
                Charger.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "DroneBullet")
        {
            ChargerHealth -= 8;
            if (ChargerHealth <= 0)
            {
                Instantiate(ExpDrop, ChargerPos, Quaternion.identity);
                Instantiate(ExpDrop, ChargerPos, Quaternion.identity);
                Charger.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "DroneExplosion")
        {
            ChargerHealth -= 75;
            if (ChargerHealth <= 0)
            {
                Instantiate(ExpDrop, ChargerPos, Quaternion.identity);
                Instantiate(ExpDrop, ChargerPos, Quaternion.identity);
                Charger.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChargeRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
        ChargerPos = Charger.transform.position;
    }

    IEnumerator ChargeRoutine()
    {
        while (true)
        {
            GetComponent<NavMeshAgent>().speed = 1.5f;
            yield return new WaitForSeconds(3.5f);
            GetComponent<NavMeshAgent>().speed = 0.45f;
            yield return new WaitForSeconds(6f);
        }
    }

}
