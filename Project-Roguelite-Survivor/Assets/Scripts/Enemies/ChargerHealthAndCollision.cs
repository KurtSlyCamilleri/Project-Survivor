using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargerHealthAndCollision : MonoBehaviour
{
    public GameObject Charger;
    public int ChargerHealth = 30;
    public GameObject ExpDrop;
    public static int ChargerDamage = 5;
    public Vector3 ChargerPos;
    public int shotgunBulletDMG = 25;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        ChargerPos = Charger.transform.position;
    }
}
