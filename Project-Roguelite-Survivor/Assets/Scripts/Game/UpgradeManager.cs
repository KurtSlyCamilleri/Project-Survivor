using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public GameObject shieldPack;
    public GameObject grenadeBelt;
    public GameObject gunDronePack;
    public GameObject bombDronePack;
    public GameObject Player;
    public Transform spawnID;
    public GameObject ShieldGearPanel;
    public GameObject GrenadeGearPanel;
    public GameObject DroneGearPanel;
    public GameObject BombGearPanel;
    public GameObject NullPanel;

    public GameObject HealthUpgrade_Panel;
    public GameObject MovementUpgrade_Panel;
    public GameObject PickUp_Panel;


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
        Time.timeScale = 1;
        ShieldGearPanel.gameObject.SetActive(false);
    }
    public void SpawnGrenade()
    {
        Vector3 spawnID = Player.transform.position;


        Quaternion direction = Quaternion.Euler(0, Player.transform.eulerAngles.y, 0);


        (Instantiate(grenadeBelt, spawnID, direction) as GameObject).transform.parent = Player.transform;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        GrenadeGearPanel.gameObject.SetActive(false);
    }
    public void SpawnGunDrone()
    {
        Vector3 spawnID = Player.transform.position;


        Quaternion direction = Quaternion.Euler(0, Player.transform.eulerAngles.y, 0);


        (Instantiate(gunDronePack, spawnID, direction) as GameObject).transform.parent = Player.transform;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        DroneGearPanel.gameObject.SetActive(false);
    }
    public void SpawnBombDrone()
    {
        Vector3 spawnID = Player.transform.position;


        Quaternion direction = Quaternion.Euler(0, Player.transform.eulerAngles.y, 0);


        (Instantiate(bombDronePack, spawnID, direction) as GameObject).transform.parent = Player.transform;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        BombGearPanel.gameObject.SetActive(false);
    }

    public void AddHealth()
    {
        

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        HealthUpgrade_Panel.gameObject.SetActive(false);
    }

    public void AddSpeed()
    {


        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        MovementUpgrade_Panel.gameObject.SetActive(false);
    }

    public void AddRadius()
    {


        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        PickUp_Panel.gameObject.SetActive(false);
    }
}
