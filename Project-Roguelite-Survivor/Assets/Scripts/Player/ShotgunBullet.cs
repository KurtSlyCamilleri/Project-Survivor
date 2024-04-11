using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunBullet : MonoBehaviour
{
    public GameObject Player;

    public static float bulletVelocity = 1.0f;

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        transform.rotation = Player.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * bulletVelocity * Time.deltaTime;
    }
}
