using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{

	//Movement
	public float playerSpeed;
	public float playerJump;
	float moveVelocity;         //Not putting private or public defaults to making variable private
	float spriteBottom;
	//Grounding Vars

	void Start(){
		spriteBottom = GetComponent<Collider>().bounds.extents.y;
	}
	void Update () 
	{
		//Jumping
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (isGrounded())
			{
				GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x , playerJump);
			}
		}
		//I feel like this line of code may make the movement seem forced? Non fluid movement
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

	bool isGrounded(){
		return Physics.Raycast(transform.position,Vector3.down, spriteBottom + 0.1f);
	}
}
