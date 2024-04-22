using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPack : MonoBehaviour
{
    public GameObject bombDrone;
    public float fireRate = 8f;
    private float lastShot = 0.0f;
    List<int> throwDirection2 = new List<int>() {-45, -25,-5, 5, 25, 45 };

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
            int spawnIndex2 = Random.Range(0, throwDirection2.Count);
            Quaternion direction = Quaternion.Euler(0, throwDirection2[spawnIndex2] + Player.transform.eulerAngles.y, 0);
            Instantiate(bombDrone, packPos, direction);

            lastShot = Time.time;
        }
    }
}
