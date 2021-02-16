using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithPlayer : MonoBehaviour, IDetectable {

	public float maxDistance = 1.5f;

	public void DetectEntry()
	{
		// 1) UI prompt "Talk to Old Man"
		NPCEvents.PromptNPCInteraction();
		PlayerInteraction.canInteractWithNPC = true;
		// 2) Show Quest Panel

	}

	public void DetectExit()
	{
		NPCEvents.HidePrompt();
		PlayerInteraction.canInteractWithNPC = false;
	}

	public float DetectionDistance()
	{
		return maxDistance;
	}
}
