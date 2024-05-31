using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerLevellingSystem : MonoBehaviour
{
    public AudioClip Up;
    public AudioClip LevelUp;
    public int PlayerLevel = 0;
    public int PlayerExp = 0;
    public int LevelUpReq = 100;
    public Slider expSlider;
    public GameObject TheBoss;
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

    public GameObject FireRate_Panel;
    public GameObject SpraySpread_Panel;
    public GameObject Piercing_Panel;
    public GameObject Damage_Panel;
    public GameObject Fullshot_Panel;

    public GameObject HealthUpgrade_Panel2;
    public GameObject MovementUpgrade_Panel2;
    public GameObject PickUp_Panel2;
    public GameObject FireRate_Panel2;
    public GameObject SpraySpread_Panel2;
    public GameObject Piercing_Panel2;
    public GameObject Damage_Panel2;

    List<int> upgradeID = new List<int>() { 1, 2, 3, 4 };
    List<int> playerupgradeID = new List<int>() { 1, 2, 3 };
    List<int> shotgunupgradeID = new List<int>() { 1, 2, 3 , 4};
    List<int> otherID = new List<int>() { 1, 2, 3, 4 , 5, 6, 7};

    public int fireRateLimiter = 0;
    public int speedLimiter = 0;


    int chosenIndex;
    int chosenIndex2;
    int chosenIndex3;
    int chosenIndex4;

    public GameObject Charger;
    public GameObject Swarmer;
    public GameObject Sponge;
    public GameObject ChargerB;
    public GameObject SwarmerB;
    public GameObject SpongeB;
    public GameObject ChargerC;
    public GameObject SwarmerC;
    public GameObject SpongeC;
    public GameObject shotgunBullet;

    public int shottyDMG = 25;

    public int XshotgunBulletPen = 5;
    public float XshotgunBulletSpread = 0.1f;

    ChargerHealthAndCollision ChargerScript;
    SwarmerHealthAndCollision SwarmerScript;
    SpongeHealthAndCollision SpongeScript;
    ShotgunBullet ShotgunBulletScript;
    public GameObject Play_Panel;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void DamageFixCharger(ChargerHealthAndCollision dmgCharger)
    {
        ChargerScript = dmgCharger;
        ChargerScript.shotgunBulletDMG = 25;
        Time.timeScale = 1;
    }
    public void DamageFixSwarmer(SwarmerHealthAndCollision dmgSwarmer)
    {
        SwarmerScript = dmgSwarmer;
        SwarmerScript.shotgunBulletDMG = 25;
    }
    public void DamageFixSponge(SpongeHealthAndCollision dmgSponge)
    {
        SpongeScript = dmgSponge;
        SpongeScript.shotgunBulletDMG = 25;
    }


    public void PierceFixShotty(ShotgunBullet pierceShotty)
    {
        ShotgunBulletScript = pierceShotty;
        ShotgunBulletScript.shotgunBulletPen = 5;
    }

    public void SpreadFixShotty()
    {
        shotgunBullet.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
        Play_Panel.gameObject.SetActive(false);
    }


        // Update is called once per frame
        void Update()
    {
        SetEXP();

        //cheat
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F2))
        {

            PlayerExp += LevelUpReq;

        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.F4))
        {

            Instantiate(TheBoss, new Vector3 (0f, 0.52f, 0f), Quaternion.identity);

        }


        PlayerLevelUI.SetText("Level: " + PlayerLevel.ToString());
        PlayerExpUI.SetText("Exp: " + PlayerExp.ToString() + "/" + LevelUpReq.ToString());
        if (PlayerExp >= LevelUpReq)
        {
            PlayerLevel++;
            GetComponent<AudioSource>().clip = LevelUp;
            GetComponent<AudioSource>().Play();
            LevelUpReq += 50;
            PlayerExp = 0;
            Upgrade_Basic_Pannel.gameObject.SetActive(true);
            Time.timeScale = 0;


            //Gear Unlocking
            if (upgradeID.Count != 0)
            {

                chosenIndex = Random.Range(0, upgradeID.Count);

                if (upgradeID[chosenIndex] == 1)
                {
                    ShieldGearPanel.gameObject.SetActive(true);
                    
                    var button = ShieldGearPanel.GetComponentInChildren<Button>();
                    EventSystem.current.SetSelectedGameObject(button.gameObject);

                    upgradeID.Remove(1);
                }
                else if (upgradeID[chosenIndex] == 2)
                {
                    GrenadeGearPanel.gameObject.SetActive(true);

                    var button = ShieldGearPanel.GetComponentInChildren<Button>();
                    EventSystem.current.SetSelectedGameObject(button.gameObject);

                    upgradeID.Remove(2);
                }
                else if (upgradeID[chosenIndex] == 3)
                {
                    DroneGearPanel.gameObject.SetActive(true);

                    var button = ShieldGearPanel.GetComponentInChildren<Button>();
                    EventSystem.current.SetSelectedGameObject(button.gameObject);

                    upgradeID.Remove(3);
                }
                else if (upgradeID[chosenIndex] == 4)
                {
                    BombGearPanel.gameObject.SetActive(true);

                    var button = ShieldGearPanel.GetComponentInChildren<Button>();
                    EventSystem.current.SetSelectedGameObject(button.gameObject);

                    upgradeID.Remove(4);
                }
            }
            else
            {
                NullPanel.gameObject.SetActive(true);
            }

            //Player Upgrades
            if (playerupgradeID.Count != 0)
            {

                chosenIndex2 = Random.Range(0, playerupgradeID.Count);
                Debug.Log(playerupgradeID[chosenIndex2]);

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

            //Shotgun Upgrades
            if (shotgunupgradeID.Count != 0)
            {

                chosenIndex3 = Random.Range(0, shotgunupgradeID.Count);
                Debug.Log(shotgunupgradeID[chosenIndex3]);

                if (shotgunupgradeID[chosenIndex3] == 1)
                {

                    FireRate_Panel.gameObject.SetActive(true);
                    

                }
                else if (shotgunupgradeID[chosenIndex3] == 2)
                {

                    SpraySpread_Panel.gameObject.SetActive(true);

                }
                else if (shotgunupgradeID[chosenIndex3] == 3)
                {

                    Piercing_Panel.gameObject.SetActive(true);

                }
                else if (shotgunupgradeID[chosenIndex3] == 4)
                {

                    Damage_Panel.gameObject.SetActive(true);

                }
            }
            else
            {
                Fullshot_Panel.gameObject.SetActive(true);
            }

            //other upgrades
            if (otherID.Count != 0)
            {

                chosenIndex4 = Random.Range(0, otherID.Count);
                Debug.Log(otherID[chosenIndex4]);

                if (otherID[chosenIndex4] == 1)
                {

                    FireRate_Panel2.gameObject.SetActive(true);


                }
                else if (otherID[chosenIndex4] == 2)
                {

                    SpraySpread_Panel2.gameObject.SetActive(true);

                }
                else if (otherID[chosenIndex4] == 3)
                {

                    Piercing_Panel2.gameObject.SetActive(true);

                }
                else if (otherID[chosenIndex4] == 4)
                {

                    Damage_Panel2.gameObject.SetActive(true);

                }
                else if (otherID[chosenIndex4] == 5)
                {

                    HealthUpgrade_Panel2.gameObject.SetActive(true);


                }
                else if (otherID[chosenIndex4] == 6)
                {
                    PickUp_Panel2.gameObject.SetActive(true);
                    


                }
                else if (otherID[chosenIndex4] == 7)
                {

                    MovementUpgrade_Panel2.gameObject.SetActive(true);

                }
            }
            else
            {
                Fullshot_Panel.gameObject.SetActive(true);
            }

        }
        if (fireRateLimiter == 1)
        {
            shotgunupgradeID.Remove(1);
            otherID.Remove(1);
        }
        if (speedLimiter == 1)
        {
            playerupgradeID.Remove(2);
            otherID.Remove(7);
        }

    }

    void OnTriggerEnter(Collider targetObj)
    {
        if (targetObj.gameObject.tag == "Experience")
        {
            PlayerExp += 15;
            GetComponent<AudioSource>().clip = Up;
            GetComponent<AudioSource>().Play();
            Destroy(targetObj.gameObject);
        }
    }

    private void SetEXP()
    {
        expSlider.value = PlayerExp / (float)LevelUpReq;
    }

}