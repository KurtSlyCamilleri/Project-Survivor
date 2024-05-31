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
    public GameObject enemyOneB;
    public GameObject enemyTwoB;
    public GameObject enemyThreeB;
    public GameObject enemyOneC;
    public GameObject enemyTwoC;
    public GameObject enemyThreeC;
    public GameObject TheBoss;
    PlayerLevellingSystem PlayerLevelSys;
    public int Stage = 1;
    public int Difficulty = 1;
    public static int PlayerPower = 0;
    public Transform Player;
    public float x = 0f;
    public static float running = 0;
    public int spawnRate1 = 8;
    public int spawnRate2 = 25;
    public int spawnRate3 = 40;
    public bool LabEntered = false;
    public bool BossRoom = false;
    public GameObject Teleporter;
    public GameObject BossDoor;


    void Update()
    {
        PlayerPower = PlayerLevelSys.PlayerLevel;

        if (Difficulty == 1)
        {
            if (PlayerPower == Stage && spawnRate1 > 1)
            {
                spawnRate1 -= 2;
                spawnRate2 -= 2;
                spawnRate3 -= 2;
                Stage += 1;
                Debug.Log("New Stage" + Stage);
            }
            if (PlayerPower == 5)
            {
                Stage += 1;
                Difficulty++;

                StopCoroutine(SpawnRoutine(enemyOne,
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

                StopCoroutine(SpawnRoutine2(enemyOne,
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

                StopCoroutine(SpawnRoutine(enemyTwo, new List<Vector3>()
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

                StopCoroutine(SpawnRoutine(enemyThree, new List<Vector3>()
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

                Debug.Log("New Difficulty" + Difficulty);
                spawnRate1 = 8;
                spawnRate2 = 25;
                spawnRate3 = 40;

                StartCoroutine(SpawnRoutine(enemyOneB, new List<Vector3>()
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
                StartCoroutine(SpawnRoutine2(enemyOneB, new List<Vector3>()
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

                StartCoroutine(SpawnRoutine(enemyTwoB, new List<Vector3>()
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

                StartCoroutine(SpawnRoutine(enemyThreeB, new List<Vector3>()
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

        }
        else if (Difficulty == 2)
        {
            if (PlayerPower == Stage && spawnRate1 > 1)
            {
                spawnRate1 -= 2;
                spawnRate2 -= 2;
                spawnRate3 -= 2;
                Stage += 1;
                Debug.Log("New Stage" + Stage);
            }
            if (PlayerPower == 10)
            {
                Stage += 1;
                Difficulty++;

                StopCoroutine(SpawnRoutine(enemyOneB, new List<Vector3>()
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

                StopCoroutine(SpawnRoutine2(enemyOneB, new List<Vector3>()
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

                StopCoroutine(SpawnRoutine(enemyTwoB, new List<Vector3>()
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

                StopCoroutine(SpawnRoutine(enemyThreeB, new List<Vector3>()
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

                Debug.Log("New Difficulty" + Difficulty);
                spawnRate1 = 8;
                spawnRate2 = 25;
                spawnRate3 = 40;
                Teleporter.gameObject.SetActive(true);
            }
        }
        else if (Difficulty == 3)
        {
            if (LabEntered == true)
            {
                StartCoroutine(SpawnRoutine(enemyOneC, new List<Vector3>()
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
                StartCoroutine(SpawnRoutine2(enemyOneC, new List<Vector3>()
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

                StartCoroutine(SpawnRoutine(enemyTwoC, new List<Vector3>()
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

                StartCoroutine(SpawnRoutine(enemyThreeC, new List<Vector3>()
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

            if (PlayerPower == Stage && spawnRate1 > 1)
            {
                spawnRate1 -= 2;
                spawnRate2 -= 2;
                spawnRate3 -= 2;
                Stage += 1;
                Debug.Log("New Stage" + Stage);
            }

            if (PlayerPower <= 15)
            {
                StopCoroutine(SpawnRoutine(enemyOneC, new List<Vector3>()
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
                StopCoroutine(SpawnRoutine2(enemyOneC, new List<Vector3>()
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

                StopCoroutine(SpawnRoutine(enemyTwoC, new List<Vector3>()
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

                StopCoroutine(SpawnRoutine(enemyThreeC, new List<Vector3>()
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
                if(BossRoom == true)
                {
                    BossDoor.gameObject.SetActive(true);
                    Instantiate(TheBoss, new Vector3(18.142f, 0.52f, -40.125f), Quaternion.identity);
                }
                
            }
        }
        




    }
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

        StartCoroutine(SpawnRoutine2(enemyOne,
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

        PlayerLevelSys = GameObject.Find("CollectRadius").GetComponent<PlayerLevellingSystem>();

    }

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag == "Player")
        {
            LabEntered = true;
        }
        else if (targetObj.gameObject.tag == "Player" && PlayerPower >= 15)
        {
            BossRoom = true;
        }
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
    IEnumerator SpawnRoutine2(GameObject enemy, List<Vector3> offsets, float spawnDelay)
    {
        while (true)
        {
            int spawnId = Random.Range(0, offsets.Count);

            Instantiate(enemy, Player.position + offsets[spawnId], Quaternion.identity);

            Instantiate(enemy, Player.position + offsets[spawnId], Quaternion.identity);

            Instantiate(enemy, Player.position + offsets[spawnId], Quaternion.identity);

            Instantiate(enemy, Player.position + offsets[spawnId], Quaternion.identity);
            yield return new WaitForSeconds(spawnDelay);

        }
    }
}