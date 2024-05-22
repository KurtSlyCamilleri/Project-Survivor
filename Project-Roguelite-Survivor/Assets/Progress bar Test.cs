using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressbarTest : MonoBehaviour
{

    private gameObject Slider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetFillAreaFill();
    }

    void GetFillAreaFill()
    {
        float fillAmount = (float)Value / (float)Max Value;
        FillArea.fillAmount = fillAmount;
    }

}
