using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Attributes/Water")]
public class WaterAttribute : MonoBehaviour
{
	[HideInInspector]
	public int playerId;

	//This will create a dialog window asking for which dialog to add
	private void Reset()
	{
		Utils.Collider2DDialogWindow(this.gameObject, true);
	}
}
