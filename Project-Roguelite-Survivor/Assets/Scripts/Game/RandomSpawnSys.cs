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
        //StartCoroutine("SpawnRoutine1");
        //StartCoroutine("SpawnRoutine2");
        //StartCoroutine("SpawnRoutine3");

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
        //StartCoroutine(SpawnRoutine(enemyTwo, spawnRate2));
        //StartCoroutine(SpawnRoutine(enemyThree, spawnRate3));
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

    IEnumerator SpawnRoutine1()
    {
        while(running == 0)
        {
            spawnOne = Random.Range(0,10);
            if(spawnOne == 1)
            {
                Player.position = new Vector3(Player.position.x, Player.position.y, Player.position.z - 4);
                Instantiate(enemyOne, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 2)
            {
                Player.position = new Vector3(Player.position.x - 4, Player.position.y , Player.position.z);
                Instantiate(enemyOne, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 3)
            {
                Player.position = new Vector3(Player.position.x - 4, Player.position.y , Player.position.z - 4);
                Instantiate(enemyOne, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 4)
            {
                Player.position = new Vector3(Player.position.x, Player.position.y , Player.position.z + 4);
                Instantiate(enemyOne, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 5)
            {
                Player.position = new Vector3(Player.position.x + 4, Player.position.y , Player.position.z);
                Instantiate(enemyOne, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 6)
            {
                Player.position = new Vector3(Player.position.x + 4, Player.position.y , Player.position.z + 4);
                Instantiate(enemyOne, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 7)
            {
                Player.position = new Vector3(Player.position.x + 4, Player.position.y , Player.position.z - 4);
                Instantiate(enemyOne, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 8)
            {
                Player.position = new Vector3(Player.position.x - 4, Player.position.y , Player.position.z + 4);
                Instantiate(enemyOne, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 9)
            {
                Player.position = new Vector3(Player.position.x + 6, Player.position.y , Player.position.z);
                Instantiate(enemyOne, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else
            {
                Player.position = new Vector3(Player.position.x - 6, Player.position.y , Player.position.z - 4);
                Instantiate(enemyOne, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }

        }
    }

    IEnumerator SpawnRoutine2()
    {
        while(running == 0)
        {
            spawnTwo = Random.Range(0,10);
            if (spawnTwo == 1)
            {
                Player.position = new Vector3(Player.position.x, Player.position.y , Player.position.z - 4);
                Instantiate(enemyTwo, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 2)
            {
                Player.position = new Vector3(Player.position.x - 4, Player.position.y , Player.position.z);
                Instantiate(enemyTwo, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 3)
            {
                Player.position = new Vector3(Player.position.x - 4, Player.position.y , Player.position.z - 4);
                Instantiate(enemyTwo, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 4)
            {
                Player.position = new Vector3(Player.position.x, Player.position.y , Player.position.z + 4);
                Instantiate(enemyTwo, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 5)
            {
                Player.position = new Vector3(Player.position.x + 4, Player.position.y , Player.position.z);
                Instantiate(enemyTwo, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 6)
            {
                Player.position = new Vector3(Player.position.x + 4, Player.position.y , Player.position.z + 4);
                Instantiate(enemyTwo, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 7)
            {
                Player.position = new Vector3(Player.position.x + 4, Player.position.y , Player.position.z - 4);
                Instantiate(enemyTwo, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 8)
            {
                Player.position = new Vector3(Player.position.x - 4, Player.position.y , Player.position.z + 4);
                Instantiate(enemyTwo, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 9)
            {
                Player.position = new Vector3(Player.position.x + 6, Player.position.y , Player.position.z);
                Instantiate(enemyTwo, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else
            {
                Player.position = new Vector3(Player.position.x - 6, Player.position.y , Player.position.z - 4);
                Instantiate(enemyTwo, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
        }
    }

    IEnumerator SpawnRoutine3()
    {
        while(running == 0)
        {
            spawnThree = Random.Range(0,10);
            if (spawnThree == 1)
            {
                Player.position = new Vector3(Player.position.x, Player.position.y , Player.position.z - 4);
                Instantiate(enemyThree, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 2)
            {
                Player.position = new Vector3(Player.position.x - 4, Player.position.y , Player.position.z);
                Instantiate(enemyThree, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 3)
            {
                Player.position = new Vector3(Player.position.x - 4, Player.position.y , Player.position.z - 4);
                Instantiate(enemyThree, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 4)
            {
                Player.position = new Vector3(Player.position.x, Player.position.y , Player.position.z + 4);
                Instantiate(enemyThree, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 5)
            {
                Player.position = new Vector3(Player.position.x + 4, Player.position.y , Player.position.z);
                Instantiate(enemyThree, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 6)
            {
                Player.position = new Vector3(Player.position.x + 4, Player.position.y , Player.position.z + 4);
                Instantiate(enemyThree, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 7)
            {
                Player.position = new Vector3(Player.position.x + 4, Player.position.y , Player.position.z - 4);
                Instantiate(enemyThree, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 8)
            {
                Player.position = new Vector3(Player.position.x - 4, Player.position.y , Player.position.z + 4);
                Instantiate(enemyThree, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 9)
            {
                Player.position = new Vector3(Player.position.x + 6, Player.position.y , Player.position.z);
                Instantiate(enemyThree, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else
            {
                Player.position = new Vector3(Player.position.x - 6, Player.position.y , Player.position.z - 4);
                Instantiate(enemyThree, Player.position, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
        }
    }
}