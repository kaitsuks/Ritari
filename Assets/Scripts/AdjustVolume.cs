using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Liitetään Main cameraan, MASTER VOLUME
public class AdjustVolume : MonoBehaviour {
    Slider sl;
    //private Text t;
    private GameObject go;
    //public  GameObject go2; //jos tarvitaan myöhemmin
    //public AudioSource audioSource; //jos tarvitaan
    //AudioListener audioListener; // ei näin!
    private float val;

    //This is Main Camera in the Scene
    //Camera m_MainCamera;

    // Use this for initialization
    void Awake () {
        go = GameObject.Find("sliderVolume");
        sl = go.GetComponent<Slider>();
        
        //t = go2.GetComponent<Text>();
        //This gets the Main Camera from the Scene
        //ei tarvita tässä: m_MainCamera = Camera.main;
        //ei näin: audioListener = m_MainCamera.GetComponent<AudioListener>();
    }
    //Voidaan säätää audiosourcea...
	public void Adjust()
    {
        //val = sl.value;
        //t.text = val.ToString();
        //audioSource.volume = val;
        
     }
    //Säädetään master volumea
    public void ChangeVol()
    {
        val = sl.value;
        AudioListener.volume = val;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
