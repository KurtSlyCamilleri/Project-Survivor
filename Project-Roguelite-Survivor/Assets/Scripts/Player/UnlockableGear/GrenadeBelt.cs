using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeBelt : MonoBehaviour
{
    public GameObject Grenade;
    public GameObject Player;
    public int throwSpeed = 15;
    public Transform Belt;
    public int spawnRot = 0;
    List<int> throwDirection = new List<int>() { 45, 90, 135 ,180, 225 ,270, 315, 360};


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        Belt = Player.transform;
        StartCoroutine(GrenadeBeltRoutine());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GrenadeBeltRoutine()
    {
        while (true)
        {
            // This is the INDEX (not value) of an array item
            int spawnIndex = Random.Range(0, throwDirection.Count);

            // Since you're only offsetting the belt on the Y axis, this is shorter
            Vector3 belt = Player.transform.position + Vector3.up * 0.2f;

            // Note that here we're using throwDirection[spawnIndex] to refer to the array value
            Quaternion direction = Quaternion.Euler(0, throwDirection[spawnIndex] + Player.transform.eulerAngles.y, 0);

            // This way is a little easier to read
            Instantiate(Grenade, belt, direction);

            // Wait
            yield return new WaitForSeconds(throwSpeed);
        }
    }
}
