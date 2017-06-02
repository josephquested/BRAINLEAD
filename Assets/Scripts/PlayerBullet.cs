﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{
		StartCoroutine(MovementRoutine());
	}

	// MOVEMENT //

	public float speed;
	public float movementDelay;

	IEnumerator MovementRoutine ()
	{
		transform.Translate(Vector2.down);
		yield return new WaitForSeconds(movementDelay);
		StartCoroutine(MovementRoutine());
	}
}
