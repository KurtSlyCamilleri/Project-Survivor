using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public GameObject shieldPack;
    public GameObject Player;
    public Transform spawnID;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnShield()
    {
        Vector3 spawnID = Player.transform.position;

        
        Quaternion direction = Quaternion.Euler(0, Player.transform.eulerAngles.y, 0);


        (Instantiate(shieldPack, spawnID, direction) as GameObject).transform.parent = Player.transform;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
    }
}
