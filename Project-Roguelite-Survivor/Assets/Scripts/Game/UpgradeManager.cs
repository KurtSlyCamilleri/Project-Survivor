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
    public float speedMax = 1f;
    public float speedChecker = 0.5f;
    public GameObject PickUp_Panel;

    public GameObject FireRate_Panel;
    public float fireRateMax = 0.2f;
    public float fireRateChecker = 2f;
    PlayerLevellingSystem PlayerLevellingScript;
    public GameObject SpraySpread_Panel;
    public GameObject Piercing_Panel;
    public GameObject Damage_Panel;

    public GameObject shotgunBullet;

    public GameObject HealthUpgrade_Panel2;
    public GameObject MovementUpgrade_Panel2;
    public GameObject PickUp_Panel2;
    public GameObject FireRate_Panel2;
    public GameObject SpraySpread_Panel2;
    public GameObject Piercing_Panel2;
    public GameObject Damage_Panel2;

    PlayerHealthAndCollision PlayerHealthScript;
    PlayerMovement PlayerSpeedScript;
    PlayerMovement PlayerSpeedScript2;
    Shotgun ShotgunScript;
    ShotgunBullet ShotgunBulletScript;
    public float shotgunSpreadInc = 0.05f;

    ChargerHealthAndCollision ChargerScript;
    SwarmerHealthAndCollision SwarmerScript;
    SpongeHealthAndCollision SpongeScript;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }




    //Gear Unlocks
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


        (Instantiate(gunDronePack, spawnID + new Vector3(+ 0.1f, 0 ,0), direction) as GameObject).transform.parent = Player.transform;

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

    //Player Upgrades
    public void AddHealth(PlayerHealthAndCollision health)
    {
        PlayerHealthScript = health;
        PlayerHealthScript.MaximumPlayerHealth += 20;
        PlayerHealthScript.PlayerHealth += 20;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        HealthUpgrade_Panel.gameObject.SetActive(false);
    }

    public void AddSpeed(PlayerMovement speed)
    {
        PlayerSpeedScript = speed;
        PlayerSpeedScript.speed += 0.1f;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        MovementUpgrade_Panel.gameObject.SetActive(false);
    }

    public void SpeedChecking(PlayerLevellingSystem speedlimit)
    {
        PlayerLevellingScript = speedlimit;
        
        speedChecker += 0.1f;
        if (speedChecker == speedMax)
        {
            PlayerLevellingScript.speedLimiter += 1;
        }
    }

    

        public void AddRadius()
    {
        GameObject.FindGameObjectWithTag("CollectRadius").GetComponent<SphereCollider>().radius += 2;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        PickUp_Panel.gameObject.SetActive(false);
    }

    //Shotgun Upgrades
    public void FireRate(Shotgun firerate)
    {
        ShotgunScript = firerate;
        ShotgunScript.fireRate -= 0.2f;
        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        FireRate_Panel.gameObject.SetActive(false);
    }

    public void FireRateChecking(PlayerLevellingSystem limiter)
    {
        PlayerLevellingScript = limiter;
        fireRateChecker -= 0.2f;
        if (fireRateChecker == fireRateMax)
        {
            PlayerLevellingScript.fireRateLimiter += 1;
        }
    }



        public void SpraySpread()
    {
        shotgunBullet.transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        SpraySpread_Panel.gameObject.SetActive(false);
    }

    public void Piercing(ShotgunBullet pierce)
    {
        ShotgunBulletScript = pierce;
        ShotgunBulletScript.shotgunBulletPen += 2;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        Piercing_Panel.gameObject.SetActive(false);
    }

    public void ChargerDamage(ChargerHealthAndCollision chargerScript)
    {
        ChargerScript = chargerScript;


        ChargerScript.shotgunBulletDMG += 10;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        Damage_Panel.gameObject.SetActive(false);
    }
    public void SwarmerDamage(SwarmerHealthAndCollision swarmerScript)
    {

        SwarmerScript = swarmerScript;



        SwarmerScript.shotgunBulletDMG += 10;

    }
    public void SpongeDamage(SpongeHealthAndCollision spongeScript)
    {

        SpongeScript = spongeScript;


        SpongeScript.shotgunBulletDMG += 10;

    }

    //Other Upgrades
    //Player Upgrades2
    public void AddHealth2(PlayerHealthAndCollision health)
    {
        PlayerHealthScript = health;
        PlayerHealthScript.MaximumPlayerHealth += 20;
        PlayerHealthScript.PlayerHealth += 20;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        HealthUpgrade_Panel2.gameObject.SetActive(false);
    }

    public void AddSpeed2(PlayerMovement speed)
    {
        PlayerSpeedScript = speed;
        PlayerSpeedScript.speed += 0.1f;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        MovementUpgrade_Panel2.gameObject.SetActive(false);
    }

    public void AddRadius2()
    {
        GameObject.FindGameObjectWithTag("CollectRadius").GetComponent<SphereCollider>().radius += 2;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        PickUp_Panel2.gameObject.SetActive(false);
    }

    //Shotgun Upgrades2
    public void FireRate2(Shotgun firerate)
    {
        ShotgunScript = firerate;
        ShotgunScript.fireRate -= 0.2f;
        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        FireRate_Panel2.gameObject.SetActive(false);
    }


    public void SpraySpread2()
    {
        shotgunBullet.transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        SpraySpread_Panel2.gameObject.SetActive(false);
    }

    public void Piercing2(ShotgunBullet pierce)
    {
        ShotgunBulletScript = pierce;
        ShotgunBulletScript.shotgunBulletPen += 2;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        Piercing_Panel2.gameObject.SetActive(false);
    }

    public void ChargerDamage2(ChargerHealthAndCollision chargerScript)
    {
        ChargerScript = chargerScript;


        ChargerScript.shotgunBulletDMG += 10;

        GameObject[] canvasList = GameObject.FindGameObjectsWithTag("UpgradeUI");
        foreach (GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }
        Time.timeScale = 1;
        Damage_Panel2.gameObject.SetActive(false);
    }
    public void SwarmerDamage2(SwarmerHealthAndCollision swarmerScript)
    {

        SwarmerScript = swarmerScript;



        SwarmerScript.shotgunBulletDMG += 10;

    }
    public void SpongeDamage2(SpongeHealthAndCollision spongeScript)
    {

        SpongeScript = spongeScript;


        SpongeScript.shotgunBulletDMG += 10;

    }

    
}
