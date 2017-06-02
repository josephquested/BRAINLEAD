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
			Move(Vector2.up);
		}
		if (Input.GetButtonDown("Right"))
		{
			Move(Vector2.right);
		}
		if (Input.GetButtonDown("Down"))
		{
			Move(Vector2.down);
		}
		if (Input.GetButtonDown("Left"))
		{
			Move(Vector2.left);
		}
	}

	void Move (Vector2 movement)
	{
		rb.AddForce(movement * speed, ForceMode2D.Impulse);
	}

	// ATTACK //

	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	void UpdateFire ()
	{
		if (Input.GetButtonDown("Fire"))
		{
			Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		}
	}
}
