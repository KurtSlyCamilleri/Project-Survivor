using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomSpawnSys : MonoBehaviour
{

    public GameObject enemyOne;
    public GameObject enemyTwo;
    public GameObject enemyThree;
    public Transform Player;
    public float x = 0f;
    public static float running = 0; 
    public int spawnOne = 0;
    public int spawnTwo = 0;
    public int spawnThree = 0;
    public static int spawnRate1 = 5;
    public static int spawnRate2 = 8;
    public static int spawnRate3 = 12;

    void Start()
    {
        
        StartCoroutine(SpawnRoutine(enemyOne,
            new List<Vector3>()
            {
                new Vector3(0, 0, -4),
                new Vector3(-4, 0, 0),
                new Vector3(-4, 0, -4),
                new Vector3(0, 0, 4),
                new Vector3(4, 0, 0),
                new Vector3(4, 0, 4),
                new Vector3(4, 0, -4),
                new Vector3(-4, 0, 4),
                new Vector3(6, 0, 0),
                new Vector3(-6, 0, -4)
            }, spawnRate1));

        StartCoroutine(SpawnRoutine(enemyTwo, new List<Vector3>()
            {
                new Vector3(0, 0, -5),
                new Vector3(-5, 0, 0),
                new Vector3(-3, 0, -5),
                new Vector3(0, 0, 5),
                new Vector3(5, 0, 0),
                new Vector3(5, 0, 3),
                new Vector3(5, 0, -3),
                new Vector3(-5, 0, 3),
                new Vector3(-5, 0, -3),
                new Vector3(3, 0, 5)
            }, spawnRate2));

        StartCoroutine(SpawnRoutine(enemyThree, new List<Vector3>()
            {
                new Vector3(0, 0, -4),
                new Vector3(-4, 0, 0),
                new Vector3(-4, 0, -4),
                new Vector3(0, 0, 4),
                new Vector3(4, 0, 0),
                new Vector3(4, 0, 4),
                new Vector3(4, 0, -4),
                new Vector3(-4, 0, 4),
                new Vector3(6, 0, 0),
                new Vector3(-6, 0, -4)
            }, spawnRate3));
    }

    IEnumerator SpawnRoutine(GameObject enemy, List<Vector3> offsets, float spawnDelay)
    {
        while (true)
        {
            int spawnId = Random.Range(0, offsets.Count);

            Instantiate(enemy, Player.position + offsets[spawnId], Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);

        }
    }
}