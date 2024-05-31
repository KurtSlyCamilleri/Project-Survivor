using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    public GameObject Bullet;
    public float fireRate = 0.5f;
    private float lastShot = 0.0f;
    public AudioClip Shoot;


    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        fireRate = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 gunPos = Player.transform.position;


        if (Time.time > fireRate + lastShot)
        {

            Instantiate(Bullet, gunPos, Quaternion.identity);
            GetComponent<AudioSource>().clip = Shoot;
            GetComponent<AudioSource>().Play();
            lastShot = Time.time;
        }
    }
}
