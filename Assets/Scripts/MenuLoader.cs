using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLoader : MonoBehaviour
{
    public GameObject objectToAffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadMenu()
    {
        if (objectToAffect != null)
        {
            
            {
                objectToAffect.SetActive(!objectToAffect.activeSelf);
            }
        }
    }
}
