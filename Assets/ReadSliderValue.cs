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
        tValue = GetComponentInChildren<Text>();
        slider = GameObject.Find("SliderTest").GetComponent<Slider>();
    }

    public void ReadIt()
    {
        tValue.text = slider.value.ToString(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
