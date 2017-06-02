using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// SYSTEM //

	void Update ()
	{
		UpdateMovement();
		UpdateBulletControl();
		UpdateFire();
	}

	// MOVEMENT //

	public float speed;

	void UpdateMovement ()
	{
		if (Input.GetButtonDown("Right"))
		{
			transform.Translate(Vector2.right);
		}
		if (Input.GetButtonDown("Left"))
		{
			transform.Translate(Vector2.left);
		}
	}

	// ATTACK //

	public GameObject pinkBulletPrefab;
	public GameObject blueBulletPrefab;
	public Transform bulletSpawn;

	PlayerBullet controlledBullet;

	void UpdateFire ()
	{
		if (Input.GetButtonDown("Fire Pink"))
		{
			FireBullet(pinkBulletPrefab);
		}
		if (Input.GetButtonDown("Fire Blue"))
		{
			FireBullet(blueBulletPrefab);
		}
	}

	void FireBullet (GameObject bulletPrefab)
	{
		var bulletObj = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
		controlledBullet = bulletObj.GetComponent<PlayerBullet>();
	}

	// BULLET CONTROL //

	void UpdateBulletControl ()
	{
		if (Input.GetButtonDown("Bullet Right") && controlledBullet != null)
		{
			controlledBullet.transform.Translate(Vector2.right);
		}
		if (Input.GetButtonDown("Bullet Left") && controlledBullet != null)
		{
			controlledBullet.transform.Translate(Vector2.left);
		}
	}
}
