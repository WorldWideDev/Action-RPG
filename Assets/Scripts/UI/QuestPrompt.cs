using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestPrompt : MonoBehaviour {

	public GameObject panel;
	void Awake()
	{
		panel.SetActive(false);
		NPCEvents.onHidePrompt += HidePanel;
		NPCEvents.onRenderPanel += ShowPanel;
	}

	public void ShowPanel()
	{
		panel.SetActive(true);
	}

	public void HidePanel()
	{
		panel.SetActive(false);
	}

	public void AcceptQuest()
	{
		NPCEvents.StartQuest();
	}

	public void DeclineQuest()
	{
		HidePanel();
	}
}
