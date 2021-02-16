using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour, IDetectable {

	public float maxDistance = 5f;
	public GameObject player;
	public void DetectEntry()
	{
		print("facing the player");
		transform.LookAt(player.transform);
	}

	public void DetectExit()
	{
		
	}

	public float DetectionDistance()
	{
		return maxDistance;
	}
}
