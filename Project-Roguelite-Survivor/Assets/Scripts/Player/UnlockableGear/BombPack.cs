using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPack : MonoBehaviour
{
    public GameObject bombDrone;
    public float fireRate = 8f;
    private float lastShot = 0.0f;

    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 packPos = Player.transform.position;

        if (Time.time > fireRate + lastShot)
        {
            Quaternion direction = Quaternion.Euler(0, 180 + Player.transform.eulerAngles.y, 0);
            Debug.Log(direction);
            Instantiate(bombDrone, packPos, direction);

            lastShot = Time.time;
        }
    }
}
