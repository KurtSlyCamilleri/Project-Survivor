using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public static int highScr = 0;
    public TextMeshProUGUI highScore;
    public TextMeshProUGUI newScore;
    // Start is called before the first frame update
    void Start()
    {
        if(highScr < ScoreUI.scr)
        {
            highScr = ScoreUI.scr;
        }
        highScore.SetText("Highest Score: " + highScr.ToString());
        newScore.SetText("New Score: " + ScoreUI.scr.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
