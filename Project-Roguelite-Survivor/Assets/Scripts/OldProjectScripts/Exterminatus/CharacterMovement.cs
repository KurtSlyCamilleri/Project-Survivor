using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public static float shipSpeed = 5f;
    public GameObject PlayerShip;
    public GameObject fruit;
    public GameObject Scrap;
    public GameObject Enemy;
    public static int FireRateMeter = 0;
    public static int BulletVelMeter = 0;
    public GameManagerSys hitDetection;
    public Animator myShip;


    

    private float xMin, xMax;
    private float yMin, yMax;

    /*public GameObject Center;
    public GameObject Left;
    public GameObject Right;

    private Vector3 posCenter;
    private Vector3 posLeft;
    private Vector3 posRight;*/

    public HealthUI hpUI;

    // Start is called before the first frame update
    void Start()
    {
        
        /*posCenter = Center.transform.position;
        posLeft = Left.transform.position;
        posRight = Right.transform.position;*/
        
        var spriteSize = GetComponent<SpriteRenderer>().bounds.size.x * .5f;
        var cam = Camera.main;
        var camHeight = cam.orthographicSize;
        var camWidth = cam.orthographicSize * cam.aspect;

        yMin = -camHeight + spriteSize;
        yMax = camHeight - spriteSize;
         
        xMin = -camWidth + spriteSize;
        xMax = camWidth - spriteSize;
    }

    // Update is called once per frame
    void Update()
    {
        var hor = Input.GetAxisRaw("Horizontal");

        var direction = new Vector2(hor, 0).normalized;
        direction *= shipSpeed * Time.deltaTime; // apply speed
 
        var xValidPosition = Mathf.Clamp(transform.position.x + direction.x, xMin, xMax);
        var yValidPosition = Mathf.Clamp(transform.position.y + direction.y, yMin, yMax);

 
        transform.position = new Vector3(xValidPosition, -4, 0f);

        if(Input.GetKeyDown("a"))
        {
            PlayerShip.GetComponent<Animator>().Play("Left");
        }
        else if(Input.GetKeyUp("a"))
        {
            PlayerShip.GetComponent<Animator>().Play("Condor");
        }

        if(Input.GetKeyDown("d"))
        {
            PlayerShip.GetComponent<Animator>().Play("Right");
        }
        else if(Input.GetKeyUp("d"))
        {
            PlayerShip.GetComponent<Animator>().Play("Condor");
        }




        
        /*if(Input.GetKeyDown(KeyCode.A))
        {
            PlayerShip.transform.position = posLeft;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            PlayerShip.transform.position = posCenter;
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            PlayerShip.transform.position = posRight;
        }
        else
        {

        }*/
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    void OnTriggerEnter2D (Collider2D targetObj) 
    {
        if(targetObj.gameObject.tag == "MedKit")
        {
            HealthUI.hp += 1;
            Destroy(targetObj.gameObject);
            ScoreUI.scr +=3;
            GameManagerSys.upgradeDetection++;
        }
        else if(targetObj.gameObject.tag == "SpeedKit")
        {
            BulletVelMeter++;
            Destroy(targetObj.gameObject);
            ScoreUI.scr +=2;
            GameManagerSys.upgradeDetection++;
            if(BulletVelMeter == 1)
            {
                BulletCollisionSys.bulletVelocity += 1.0f;
                Debug.Log("Bullet Velocity Up!");
            }
            else if(BulletVelMeter == 2)
            {
                BulletCollisionSys.bulletVelocity += 1.0f;
                Debug.Log("Bullet Velocity Up!");
            }
            else if(BulletVelMeter == 3)
            {
                BulletCollisionSys.bulletVelocity += 1.0f;
                Debug.Log("Bullet Velocity Up!");
            }
        }
        else if(targetObj.gameObject.tag == "RateKit")
        {
            FireRateMeter++;
            Destroy(targetObj.gameObject);
            ScoreUI.scr +=1;
            GameManagerSys.upgradeDetection++;
            if(FireRateMeter == 1)
            {
                CharacterWeaponSys.fireRate -= 1.0f;
                Debug.Log("Fire Rate Up!");
            }
            else if(FireRateMeter == 2)
            {
                CharacterWeaponSys.fireRate -= 1.0f;
                Debug.Log("Fire Rate Up!");
            }
            else if(FireRateMeter == 3)
            {
                CharacterWeaponSys.fireRate -= 1.0f;
                Debug.Log("Fire Rate Up!");
            }
        }
        else if(targetObj.gameObject.tag == "Fragile")
        {
            HealthUI.hp -= 1;
            Destroy(targetObj.gameObject);
            GameManagerSys.hitDetection++;
        }
    }
}
