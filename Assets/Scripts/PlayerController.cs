using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update ()
	{
		UpdateMovement();
		UpdateFire();
	}

	// MOVEMENT //

	Rigidbody2D rb;

	public float speed;

	void UpdateMovement ()
	{
		if (Input.GetButtonDown("Up"))
		{
			Move(Vector2.right);
		}
		if (Input.GetButtonDown("Right"))
		{
			Move(Vector2.right);
		}
		if (Input.GetButtonDown("Down"))
		{
			Move(Vector2.right);
		}
		if (Input.GetButtonDown("Left"))
		{
			Move(Vector2.right);
		}
	}

	void Move (Vector2 movement)
	{
		rb.AddForce(movement * speed, ForceMode2D.Impulse);
	}

	// ATTACK //

	void UpdateFire ()
	{
		if (Input.GetButtonDown("Fire"))
		{
			// attack
		}
	}
}
