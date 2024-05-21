using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWave : MonoBehaviour
{
    public static float bulletVelocity = 0.2f;
    //public GameObject TheBoss;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnWave()
    {
        yield return new WaitForSeconds(1f);
        StartCoroutine(MoveWave());
    }

    IEnumerator MoveWave()
    {
        while (true)
        {
            transform.position += transform.forward * bulletVelocity * Time.deltaTime;
            yield return null;
        }
    }
}
