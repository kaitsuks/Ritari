using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Attributes/Initial Resource")]
[RequireComponent(typeof(SpriteRenderer))]
public class InitialResource : MonoBehaviour
{
	public int resourceIndex = 0; //the "type of resource", this index point to the array in the centralised InventoryResources ScriptableObject
	public int amount = 20;

	private UIScript userInterface;


	// Start is called at the beginning
	private void Awake()
	{
		// Find the UI in the scene and store a reference for later use
		userInterface = GameObject.FindObjectOfType<UIScript>();
        SetResource();
	}


	//This will create a dialog window asking for which dialog to add
	private void Reset()
	{
		Utils.Collider2DDialogWindow(this.gameObject, true);
	}


	private void SetResource()
	{
		if(userInterface != null)
			{
		    userInterface.AddResource(resourceIndex, amount, GetComponent<SpriteRenderer>().sprite);
            //userInterface.AddResource(resourceIndex, amount, null);

        }
			else
			{
				Debug.LogWarning("User Interface is not in the scene, so the resource cannot be displayed and put in the inventory.");
			}
	}
}
