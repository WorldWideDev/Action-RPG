using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour {

	public static bool canInteractWithNPC;

	void Awake()
	{
		canInteractWithNPC = false;
	}

	void Update()
	{
		if(canInteractWithNPC)
		{
			if(Input.GetKeyDown(KeyCode.X))
			{
				NPCEvents.InitiateQuest();
			}
		}
	}
}
