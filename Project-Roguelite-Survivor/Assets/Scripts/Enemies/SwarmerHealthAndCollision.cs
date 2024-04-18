using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmerHealthAndCollision : MonoBehaviour
{
    public GameObject Swarmer;
    public int SwarmerHealth = 50;
    public GameObject ExpDrop;
    public int SwarmerDamage = 10;
    public Vector3 SwarmerPos;

    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "ShotgunBullet")
        {
            SwarmerHealth -= 25;
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
