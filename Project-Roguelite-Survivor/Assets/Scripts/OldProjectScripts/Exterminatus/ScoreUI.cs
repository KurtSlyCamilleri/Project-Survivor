using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public static int scr = 0;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        scr = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.SetText("Score: " + scr.ToString());
    }
}
