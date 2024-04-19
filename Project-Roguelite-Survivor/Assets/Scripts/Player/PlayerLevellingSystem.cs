using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLevellingSystem : MonoBehaviour
{
    public int PlayerLevel = 0;
    public int PlayerExp = 0;
    public int LevelUpReq = 100;
    public TextMeshProUGUI PlayerLevelUI;
    public TextMeshProUGUI PlayerExpUI;

    public GameObject Upgrade_Basic_Pannel;
    public GameObject ShieldGearPanel;
    public GameObject GrenadeGearPanel;
    public GameObject DroneGearPanel;
    public GameObject BombGearPanel;
    public GameObject NullPanel;
    List<int> upgradeID = new List<int>() { 1, 2, 3, 4 };
    int chosenIndex;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerLevelUI.SetText("Level: " + PlayerLevel.ToString());
        PlayerExpUI.SetText("Exp: " + PlayerExp.ToString() + "/" + LevelUpReq.ToString());
        if (PlayerExp == LevelUpReq)
        {
            PlayerLevel++;
            LevelUpReq += 50;
            PlayerExp = 0;
            Upgrade_Basic_Pannel.gameObject.SetActive(true);
            Time.timeScale = 0;



            if (upgradeID.Count != 0)
            {
                Debug.Log("PreRan");
                chosenIndex = Random.Range(0, upgradeID.Count);
                Debug.Log("PostRan");
                if (upgradeID[chosenIndex] == 1)
                {
                    ShieldGearPanel.gameObject.SetActive(true);
                    Debug.Log("Shield");
                    upgradeID.Remove(1);
                }
                if (upgradeID[chosenIndex] == 2)
                {
                    GrenadeGearPanel.gameObject.SetActive(true);
                    Debug.Log("Nade");
                    upgradeID.Remove(2);
                }
                if (upgradeID[chosenIndex] == 3)
                {
                    DroneGearPanel.gameObject.SetActive(true);
                    Debug.Log("Drone");
                    upgradeID.Remove(3);
                }
                if (upgradeID[chosenIndex] == 4)
                {
                    BombGearPanel.gameObject.SetActive(true);
                    Debug.Log("Bomb");
                    upgradeID.Remove(4);
                }
            }
            else
            {
                Debug.Log("Null");
                NullPanel.gameObject.SetActive(true);
            }
        }
    }

    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "Experience")
        {
            PlayerExp += 5;
            Destroy(targetObj.gameObject);
        }
    }

}