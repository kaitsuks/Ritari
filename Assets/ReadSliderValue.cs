using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadSliderValue : MonoBehaviour
{
    Slider slider;
    Text tValue;

    // Start is called before the first frame update
    void Start()
    {
        tValue = GetComponent<Text>();
        slider = GameObject.Find("sliderVolume").GetComponent<Slider>();
    }

    public void ReadIt()
    {
        tValue.text = "Master Volume = " + Mathf.FloorToInt((slider.value * 10 + 1)).ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
