using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{
    string myName = "Your name is:";
    Text textName;
    InputField ifd;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        textName = GameObject.Find("tPlayerName2").GetComponent<Text>();
        gameManager = GameObject.Find("Manager").GetComponent<GameManager>();
        //Sets this to not be destroyed when reloading scene
        //DontDestroyOnLoad(gameObject);
        textName.text = gameManager.player;
    }
    void Awake()
    {
        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }
        // Update is called once per frame
        void Update()
    {
        //textName.text = gameManager.player;
    }
}
