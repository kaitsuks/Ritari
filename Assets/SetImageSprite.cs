using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetImageSprite : MonoBehaviour
{
    private Sprite axe;
    private GameObject im;

    // Start is called before the first frame update
    void Start()
    {
        im = GameObject.Find("ImageWeapon");
        axe = Resources.Load<UnityEngine.Sprite>("Weapons/Axe");
        im.GetComponent<Image>().sprite = axe;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
