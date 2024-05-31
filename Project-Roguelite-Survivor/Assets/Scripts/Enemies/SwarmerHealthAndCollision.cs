using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmerHealthAndCollision : MonoBehaviour
{
    public GameObject Swarmer;
    public int SwarmerHealth = 50;
    public GameObject ExpDrop;
    public Vector3 SwarmerPos;
    public int shotgunBulletDMG = 25;
    public int rifleBulletDMG = 10;

    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "ShotgunBullet")
        {
            SwarmerHealth -= shotgunBulletDMG;
            if (SwarmerHealth <= 0)
            {
                Instantiate(ExpDrop, SwarmerPos, Quaternion.identity);
                Swarmer.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "RifleBullet")
        {
            SwarmerHealth -= rifleBulletDMG;
            if (SwarmerHealth <= 0)
            {
                Instantiate(ExpDrop, SwarmerPos, Quaternion.identity);
                Swarmer.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "NadeExplosion")
        {
            SwarmerHealth -= 100;
            if (SwarmerHealth <= 0)
            {
                Instantiate(ExpDrop, SwarmerPos, Quaternion.identity);
                Swarmer.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "DroneBullet")
        {
            SwarmerHealth -= 8;
            if (SwarmerHealth <= 0)
            {
                Instantiate(ExpDrop, SwarmerPos, Quaternion.identity);
                Swarmer.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "DroneExplosion")
        {
            SwarmerHealth -= 75;
            if (SwarmerHealth <= 0)
            {
                Instantiate(ExpDrop, SwarmerPos, Quaternion.identity);
                Swarmer.GetComponent<BoxCollider>().enabled = false;
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
        SwarmerPos = Swarmer.transform.position;
    }
}
