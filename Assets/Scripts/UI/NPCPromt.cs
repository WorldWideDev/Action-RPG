using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCPromt : MonoBehaviour {

	public Text promptText;

	void Awake()
	{
		promptText.enabled = false;
		NPCEvents.onPromptInteraction += RenderPrompt;
		NPCEvents.onHidePrompt += HidePrompt;
	}
	void RenderPrompt()
	{
		promptText.enabled = true;
	}

	void HidePrompt()
	{
		promptText.enabled = false;
	}
}
