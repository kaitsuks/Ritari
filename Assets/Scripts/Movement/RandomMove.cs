using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Movement/Random Move")]
[RequireComponent(typeof(Rigidbody2D))]
public class RandomMove : Physics2DObject
{
	// These are the forces that will push the object every frame
	// don't forget they can be negative too!
	private Vector2 direction = new Vector2(0f, 0f);

    public int speed = 1;

	//is the push relative or absolute to the world?
	public bool relativeToRotation = true;

    void Start()
    {
        direction.x = Random.Range(-1.0f, 1.0f);
        direction.y = Random.Range(-1.0f, 1.0f);
    }

	
	// FixedUpdate is called once per frame
	void FixedUpdate ()
	{
		if(relativeToRotation)
		{
			rigidbody2D.AddRelativeForce(direction * 2f * speed);
		}
		else
		{
			rigidbody2D.AddForce(direction * 2f * speed);
		}
	}


	//Draw an arrow to show the direction in which the object will move
	void OnDrawGizmosSelected()
	{
		if(this.enabled)
		{
			float extraAngle = (relativeToRotation) ? transform.rotation.eulerAngles.z : 0f;
			Utils.DrawMoveArrowGizmo(transform.position, direction, extraAngle);
		}
	}
}
