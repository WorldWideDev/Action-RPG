using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCEvents : MonoBehaviour {

	public delegate void QuestHandler();
	public static event QuestHandler onPromptInteraction;
	public static event QuestHandler onHidePrompt;
	public static event QuestHandler onRenderPanel;
	public static event QuestHandler onStartQuest;

	public static void PromptNPCInteraction()
	{
		if(onPromptInteraction != null)
		{
			onPromptInteraction();
		}
	}

	public static void HidePrompt()
	{
		if(onHidePrompt != null)
		{
			onHidePrompt();
		}
	}

	public static void InitiateQuest()
	{
		if(onRenderPanel != null)
		{
			onRenderPanel();
		}
	}
	public static void StartQuest()
	{
		if(onStartQuest != null)
		{
			onStartQuest();
		}
	}





}
