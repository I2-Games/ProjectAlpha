using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

	//Movement
	public float playerSpeed;
	public float playerJump;
	float moveVelocity;         //Not putting private or public defaults to making variable private

	//Grounding Vars
	bool grounded = true;

	void Update () 
	{
		//Jumping
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (grounded)
			{
				GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x , playerJump);
			}
		}

		moveVelocity = 0;

		//Left Right Movement
		if (Input.GetKey (KeyCode.A))
	 	{
			moveVelocity = -playerSpeed;
		}
		if (Input.GetKey (KeyCode.D))
		{
			moveVelocity = playerSpeed;
		}

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);
	}

	//Check if Grounded
	void OnTriggerEnter2D()
	{
		grounded = true;
	}

	void OnTriggerExit2D()
	{
		grounded = false;
	}
}
