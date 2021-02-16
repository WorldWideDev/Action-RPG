using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTrigger : MonoBehaviour {

	IDetectable player;
	SphereCollider c;

	public enum DetectionType
	{
		FaceThePlayer,
		Interactable
	}

	public DetectionType dType;

	void SetDetectionType()
	{
		switch(dType)
		{
			case DetectionType.FaceThePlayer:
				player = transform.parent.GetComponent<FacePlayer>();
				break;
			case DetectionType.Interactable:
				player = transform.parent.GetComponent<InteractWithPlayer>();
				break;
		}
	}

	void Awake()
	{
		SetDetectionType();
		c = GetComponent<SphereCollider>();
		c.radius = player.DetectionDistance();
	}

	void OnTriggerStay(Collider other)
	{
		if(other.tag == "Player")
		{
			player.DetectEntry();
		}
	}
	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Player")
		{
			player.DetectExit();
		}
	}
}
