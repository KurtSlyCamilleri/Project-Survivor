using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpongeHealthAndCollision : MonoBehaviour
{
    public GameObject Sponge;
    public int SpongeHealth = 150;
    public GameObject ExpDrop;
    public Vector3 SpongePos;
    public int shotgunBulletDMG = 25;

    public GameObject Wave;
    public float fireRate = 10f;
    private float lastShot = 0.0f;
    public int rifleBulletDMG = 10;
 
    public AudioClip Death;

    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "ShotgunBullet")
        {
            SpongeHealth -= shotgunBulletDMG;
            if (SpongeHealth <= 0)
            {
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                GetComponent<AudioSource>().clip = Death;
                GetComponent<AudioSource>().Play();
                Sponge.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if(targetObj.gameObject.tag == "RifleBullet")
        {
            SpongeHealth -= rifleBulletDMG;
            if (SpongeHealth <= 0)
            {
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                GetComponent<AudioSource>().clip = Death;
                GetComponent<AudioSource>().Play();
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
                GetComponent<AudioSource>().clip = Death;
                GetComponent<AudioSource>().Play();
                Sponge.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "DroneBullet")
        {
            SpongeHealth -= 8;
            if (SpongeHealth <= 0)
            {
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                GetComponent<AudioSource>().clip = Death;
                GetComponent<AudioSource>().Play();
                Sponge.GetComponent<BoxCollider>().enabled = false;
                Destroy(gameObject);
            }

        }
        if (targetObj.gameObject.tag == "DroneExplosion")
        {
            SpongeHealth -= 75;
            if (SpongeHealth <= 0)
            {
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                Instantiate(ExpDrop, SpongePos, Quaternion.identity);
                GetComponent<AudioSource>().clip = Death;
                GetComponent<AudioSource>().Play();
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

        Vector3 gunPos = Sponge.transform.position;


        if (Time.time > fireRate + lastShot)
        {

            Instantiate(Wave, gunPos + new Vector3 (0f, + 0.05f, 0f), Quaternion.identity);

            lastShot = Time.time;
        }
    }
}
