using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotGetsSlapped : MonoBehaviour {

	public float slapForce = 20f;

	public bool isEnabled;
	Rigidbody rb;

	int dmgTaken;

	void Awake()
	{
		this.enabled = isEnabled;
		rb = GetComponent<Rigidbody>();
		rb.useGravity = false;
		rb.isKinematic = true;
		Robot thisRobot = new Robot();
		PlayerEvents.onAttackAttempt += Slapped;
	}

	void Slapped(int dmg)
	{
		dmgTaken = dmg;
	}


	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Player")
		{
			//print("i was slapped by the player");
			PlayerCombat pc = other.gameObject.GetComponent<PlayerCombat>();
			print(pc.isSlapping);
			if(pc.isSlapping)
			{
				print("I was hit");
				//PlayerEvents.Slap(this, dmgTaken);
				// rb.useGravity = true;
				// rb.isKinematic = false;
				// Vector3 impulse = other.impulse;
				// ContactPoint[] contacts = other.contacts;
				// foreach(ContactPoint c in contacts)
				// {
				// 	print(c.normal + " is normal of " + c.point);
				// }
				// rb.AddForce(new Vector3(impulse.x * slapForce, impulse.y * slapForce, impulse.z * slapForce));
			}
		}
	}
}
