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

    public void Unpause()
    {
        Time.timeScale = 1;
    }
    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void DelayedPause()
    {
        Debug.Log("PauseClicked");
        StartCoroutine(DelayedPausing());
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Application has quit");
    }

    public void LoadScene(string sceneName) //so we can use it for multiple scenes
    {
        SceneManager.LoadScene(sceneName);
    }

    IEnumerator DelayedPausing()
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Paused");
        Time.timeScale = 0;
    }
}
