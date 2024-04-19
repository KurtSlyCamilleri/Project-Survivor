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

    public GameObject FireRate_Panel;
    public float fireRateMax = 0.2f;
    public float fireRateChecker = 2f;
    PlayerLevellingSystem PlayerLevellingScript;
    public GameObject SpraySpread_Panel;
    public GameObject Piercing_Panel;
    public GameObject Damage_Panel;

    public GameObject shotgunBullet;

    PlayerHealthAndCollision PlayerHealthScript;
    PlayerMovement PlayerSpeedScript;
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

    //PlayerLevellingSystem PlayerLevellingScript;
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
        shotgunBullet.transform.localScale = new Vector3(0.1f + shotgunSpreadInc, 0.01f,0.02f);
        shotgunSpreadInc += 0.05f;
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
}
