using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public GameObject Bullet;
    public float fireRate = 2f;
    private float lastShot = 0.0f;

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnShoot()
    {
        Vector3 gunPos = Player.transform.position;
        if (Time.time > fireRate + lastShot)
        {
            Instantiate(Bullet, gunPos, Quaternion.identity);
            lastShot = Time.time;
        }
    }
}
