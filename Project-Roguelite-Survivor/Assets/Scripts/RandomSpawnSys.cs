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
    public static int spawnRate1 = 3;
    public static int spawnRate2 = 6;
    public static int spawnRate3 = 8;
    Vector3 posPlayer = new Vector3(0, 0, 0);

    void Start()
    {
        StartCoroutine("SpawnRoutine1");
        StartCoroutine("SpawnRoutine2");
        StartCoroutine("SpawnRoutine3");
    }

    void Update()
    {
        posPlayer = Player.transform.position;
    }

    IEnumerator SpawnRoutine1()
    {
        while(running == 0)
        {
            spawnOne = Random.Range(0,10);
            if(spawnOne == 1)
            {
                posPlayer = new Vector3(posPlayer.x, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyOne, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 2)
            {
                posPlayer = new Vector3(posPlayer.x - 4, posPlayer.y, posPlayer.z);
                Instantiate(enemyOne, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 3)
            {
                posPlayer = new Vector3(posPlayer.x - 4, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyOne, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 4)
            {
                posPlayer = new Vector3(posPlayer.x, posPlayer.y, posPlayer.z + 4);
                Instantiate(enemyOne, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 5)
            {
                posPlayer = new Vector3(posPlayer.x + 4, posPlayer.y, posPlayer.z);
                Instantiate(enemyOne, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 6)
            {
                posPlayer = new Vector3(posPlayer.x + 4, posPlayer.y, posPlayer.z + 4);
                Instantiate(enemyOne, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 7)
            {
                posPlayer = new Vector3(posPlayer.x + 4, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyOne, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 8)
            {
                posPlayer = new Vector3(posPlayer.x - 4, posPlayer.y, posPlayer.z + 4);
                Instantiate(enemyOne, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else if (spawnOne == 9)
            {
                posPlayer = new Vector3(posPlayer.x + 6, posPlayer.y, posPlayer.z);
                Instantiate(enemyOne, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate1);
            }
            else
            {
                posPlayer = new Vector3(posPlayer.x - 6, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyOne, posPlayer, Quaternion.identity);
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
                posPlayer = new Vector3(posPlayer.x, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyTwo, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 2)
            {
                posPlayer = new Vector3(posPlayer.x - 4, posPlayer.y, posPlayer.z);
                Instantiate(enemyTwo, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 3)
            {
                posPlayer = new Vector3(posPlayer.x - 4, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyTwo, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 4)
            {
                posPlayer = new Vector3(posPlayer.x, posPlayer.y, posPlayer.z + 4);
                Instantiate(enemyTwo, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 5)
            {
                posPlayer = new Vector3(posPlayer.x + 4, posPlayer.y, posPlayer.z);
                Instantiate(enemyTwo, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 6)
            {
                posPlayer = new Vector3(posPlayer.x + 4, posPlayer.y, posPlayer.z + 4);
                Instantiate(enemyTwo, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 7)
            {
                posPlayer = new Vector3(posPlayer.x + 4, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyTwo, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 8)
            {
                posPlayer = new Vector3(posPlayer.x - 4, posPlayer.y, posPlayer.z + 4);
                Instantiate(enemyTwo, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else if (spawnTwo == 9)
            {
                posPlayer = new Vector3(posPlayer.x + 6, posPlayer.y, posPlayer.z);
                Instantiate(enemyTwo, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate2);
            }
            else
            {
                posPlayer = new Vector3(posPlayer.x - 6, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyTwo, posPlayer, Quaternion.identity);
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
                posPlayer = new Vector3(posPlayer.x, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyThree, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 2)
            {
                posPlayer = new Vector3(posPlayer.x - 4, posPlayer.y, posPlayer.z);
                Instantiate(enemyThree, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 3)
            {
                posPlayer = new Vector3(posPlayer.x - 4, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyThree, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 4)
            {
                posPlayer = new Vector3(posPlayer.x, posPlayer.y, posPlayer.z + 4);
                Instantiate(enemyThree, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 5)
            {
                posPlayer = new Vector3(posPlayer.x + 4, posPlayer.y, posPlayer.z);
                Instantiate(enemyThree, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 6)
            {
                posPlayer = new Vector3(posPlayer.x + 4, posPlayer.y, posPlayer.z + 4);
                Instantiate(enemyThree, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 7)
            {
                posPlayer = new Vector3(posPlayer.x + 4, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyThree, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 8)
            {
                posPlayer = new Vector3(posPlayer.x - 4, posPlayer.y, posPlayer.z + 4);
                Instantiate(enemyThree, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else if (spawnThree == 9)
            {
                posPlayer = new Vector3(posPlayer.x + 6, posPlayer.y, posPlayer.z);
                Instantiate(enemyThree, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
            else
            {
                posPlayer = new Vector3(posPlayer.x - 6, posPlayer.y, posPlayer.z - 4);
                Instantiate(enemyThree, posPlayer, Quaternion.identity);
                yield return new WaitForSeconds(spawnRate3);
            }
        }
    }
}