using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public GameObject spriteObjekti; // vaihda oman objektisi nimi!
    Slider sl;
    SpriteRenderer m_SpriteRenderer;
    Color color;

    // Use this for initialization
    void Start()
    {

        sl = GetComponent<Slider>();
        m_SpriteRenderer = spriteObjekti.GetComponent<SpriteRenderer>(); // vaihda oman objektisi nimi!

    }

    public void ChangeColor()
    {
        byte b = (byte)(sl.value * 255);
        color = new Color32(b, 0, b, 255);
        m_SpriteRenderer.color = color;
    }


    // Update is called once per frame
    void Update()
    {

        //byte b = (byte)(sl.value * 255);
        //color = new Color32(b, 0, b, 255);
        //m_SpriteRenderer.color = color;
    }
}
