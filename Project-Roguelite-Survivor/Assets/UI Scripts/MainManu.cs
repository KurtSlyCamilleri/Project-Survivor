using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManu : MonoBehaviour
{
    public AudioClip Click;
    public AudioClip Hover;



    // This loads a new scene
    public void LoadScene(string sceneName) //so we can use it for multiple scenes
{
    SceneManager.LoadScene(sceneName);
}

    public void LoadSpecificScene(string sceneName) //so we can use it for multiple scenes
    {
        SceneManager.LoadScene("Rifle_Grounds");
    }

    

    public void ButtonClick()
    {
        GetComponent<AudioSource>().clip = Click;
        GetComponent<AudioSource>().Play();
    }
    public void ButtonHover()
    {
        GetComponent<AudioSource>().clip = Hover;
        GetComponent<AudioSource>().Play();
    }

    public void Quit()
{
    Application.Quit();
    Debug.Log("Application has quit");
}

public void ClosePanel(GameObject selected)
{
        selected.SetActive(false);
}

public void SwapPannel(GameObject selected)
{


    selected.SetActive(true);
}

}
