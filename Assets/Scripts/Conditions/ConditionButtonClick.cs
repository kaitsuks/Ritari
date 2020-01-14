using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Playground/Conditions/Condition Button Click")]

public class ConditionButtonClick : ConditionBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    public void Clicked()
    {
        ExecuteAllActions(null);
    }
}
