using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		StartCoroutine(MovementRoutine());
	}

	void Update ()
	{
		UpdateMovement();
	}

	// MOVEMENT //

	Rigidbody2D rb;

	public float speed;
	public float movementDelay;

	IEnumerator MovementRoutine ()
	{
		Move(Vector2.down);
		yield return new WaitForSeconds(movementDelay);
		StartCoroutine(MovementRoutine());
	}

	void UpdateMovement ()
	{
		if (Input.GetButtonDown("Bullet Right"))
		{
			Move(Vector2.right);
		}
		if (Input.GetButtonDown("Bullet Left"))
		{
			Move(Vector2.left);
		}
	}

	void Move (Vector2 movement)
	{
		rb.AddForce(movement * speed, ForceMode2D.Impulse);
	}
}
