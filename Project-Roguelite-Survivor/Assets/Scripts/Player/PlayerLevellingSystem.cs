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

    public GameObject HealthUpgrade_Panel;
    public GameObject MovementUpgrade_Panel;
    public GameObject PickUp_Panel;
    List<int> upgradeID = new List<int>() { 1, 2, 3, 4 };
    List<int> playerupgradeID = new List<int>() { 1, 2, 3 };

    int chosenIndex;
    int chosenIndex2;


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

                chosenIndex = Random.Range(0, upgradeID.Count);

                if (upgradeID[chosenIndex] == 1)
                {
                    ShieldGearPanel.gameObject.SetActive(true);

                    upgradeID.Remove(1);
                }
                else if (upgradeID[chosenIndex] == 2)
                {
                    GrenadeGearPanel.gameObject.SetActive(true);

                    upgradeID.Remove(2);
                }
                else if (upgradeID[chosenIndex] == 3)
                {
                    DroneGearPanel.gameObject.SetActive(true);

                    upgradeID.Remove(3);
                }
                else if (upgradeID[chosenIndex] == 4)
                {
                    BombGearPanel.gameObject.SetActive(true);

                    upgradeID.Remove(4);
                }
            }
            else
            {
                NullPanel.gameObject.SetActive(true);
            }

            if (playerupgradeID.Count != 0)
            {
                chosenIndex2 = Random.Range(0, playerupgradeID.Count);

                if (playerupgradeID[chosenIndex2] == 1)
                {
                    HealthUpgrade_Panel.gameObject.SetActive(true);

                }
                else if (playerupgradeID[chosenIndex2] == 2)
                {
                    MovementUpgrade_Panel.gameObject.SetActive(true);
                }
                else if (playerupgradeID[chosenIndex2] == 3)
                {
                    PickUp_Panel.gameObject.SetActive(true);
                }
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