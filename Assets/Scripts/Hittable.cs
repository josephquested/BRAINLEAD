using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittable : MonoBehaviour {

	// SYSTEM //

	void Start ()
	{

	}

	// COLLISION //

	public string color;

	public void ReceiveHit (PlayerBullet hit)
	{
		if (hit.color == color)
		{
			Destroy(gameObject);
		}
		else
		{
			transform.Translate(Vector2.up);
		}
	}
}
