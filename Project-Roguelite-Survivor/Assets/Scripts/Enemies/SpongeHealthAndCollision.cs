using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpongeHealthAndCollision : MonoBehaviour
{
    public GameObject Sponge;
    public int SpongeHealth = 150;
    public GameObject ExpDrop;
    public static int SpongeDamage = 20;
    public Vector3 SpongePos;

    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "ShotgunBullet")
        {
            SpongeHealth -= 25;
            if (SpongeHealth <= 0)
            {
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Sponge.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "NadeExplosion")
        {
            SpongeHealth -= 100;
            if (SpongeHealth <= 0)
            {
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Sponge.GetComponent<BoxCollider>().enabled = false;
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
        SpongePos = Sponge.transform.position;
    }
}
