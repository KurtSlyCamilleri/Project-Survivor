using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class RandomSpawnSys : MonoBehaviour
{

    public GameObject enemyOne;
    public GameObject enemyTwo;
    public GameObject enemyThree;
    PlayerLevellingSystem PlayerLevelSys;
    public int Stage = 5;
    public int PlayerPower = 0;
    public Transform Player;
    public float x = 0f;
    public static float running = 0; 
    public int spawnRate1 = 6;
    public int spawnRate2 = 9;
    public int spawnRate3 = 13;

    void Update()
    {
        PlayerPower = PlayerLevelSys.PlayerLevel;


            if (PlayerPower == Stage && spawnRate1 > 2)
            {
                spawnRate1 -= 1;
                spawnRate2 -= 1;
                spawnRate3 -= 1;
                Stage += 5;
            }
        
        
    }
    void Start()
    {
        PlayerLevelSys = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLevellingSystem>();
        
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