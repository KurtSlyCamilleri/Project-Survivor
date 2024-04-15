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
    // Start is called before the first frame update
    void Start()
    {
        PlayerLevelUI.SetText("Level: " + PlayerLevel.ToString());
        PlayerExpUI.SetText("Exp: " + PlayerExp.ToString() + "/" + LevelUpReq.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerExp == LevelUpReq)
        {
            PlayerLevel++;
            LevelUpReq += 50;
            PlayerExp = 0;
        }
    }

    void OnCollisionEnter(Collision targetObj)
    {
        if (targetObj.gameObject.tag == "Exp")
        {
            PlayerExp += 5;
        }
    }

    }
