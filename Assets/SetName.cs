using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetName : MonoBehaviour
{
    string myName = "Your name is:";
    Text textName;
    InputField ifd;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        ifd = GetComponent<InputField>();
        textName = GameObject.Find("tPlayerName").GetComponent<Text>();
        //gameManager = new GameManager(); //not allowed!!!
        gameManager = GameObject.Find("Manager").GetComponent<GameManager>();
    }

    public void SetMyName()
    {
        textName.text = myName + ifd.text;
        gameManager.player = textName.text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
