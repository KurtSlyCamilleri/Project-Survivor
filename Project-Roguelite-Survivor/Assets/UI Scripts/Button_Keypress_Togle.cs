using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Keypress_Togle : MonoBehaviour
{

    public GameObject ESC_Panel;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ESC_Panel.gameObject.SetActive(!ESC_Panel.gameObject.activeSelf);
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
            }
            else if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            }
        }

    }
    public void Quit()
    {
        SceneManager.LoadScene("Coding_Testing_Grounds");
    }
}
