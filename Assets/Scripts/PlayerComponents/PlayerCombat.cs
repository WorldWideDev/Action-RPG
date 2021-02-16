using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour {

	[HideInInspector]
	public bool isSlapping;
	[HideInInspector]
	public bool alreadySlapped;
	
	public Transform castOrigin;
	public float slapDistance = 10f;
	public float slapForce = 50f;

	void Awake()
	{
		isSlapping = false;
		alreadySlapped = false;
	}
	void Update()
	{
		if(Input.GetMouseButtonDown(1))
		{
			PlayerEvents.AttemptAttack(PlayerManager.Instance.player.SlapPower);
			alreadySlapped = false;
		}
				
		
		if(isSlapping && !alreadySlapped)
		{
			RaycastHit hit;
			if(Physics.Raycast(castOrigin.position, castOrigin.forward, out hit, slapDistance ))
			{
				if(hit.collider.tag == "Slappable")
				{
					print(hit.collider.gameObject);
					alreadySlapped = true;
					PlayerEvents.Slap(hit.collider.gameObject, PlayerManager.Instance.player.SlapPower);
					// hit.rigidbody.isKinematic = false;
					// hit.rigidbody.useGravity = true;
					// hit.rigidbody.AddForce(-hit.normal * slapForce);
				}
			}
		}
		Debug.DrawRay(castOrigin.position, castOrigin.forward * slapDistance, Color.green);
	}
}
