using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour 
{
    public int MobsToKill = 5;

    KillMobsRequirement questTask;
    List<Requirement> taskList;
    Quest killMobQuest;
    void InitializeQuest()
    {
        // initialize mob quest
        print("Quest Started");
        questTask = new KillMobsRequirement(MobsToKill);
        taskList = new List<Requirement>();
        taskList.Add(questTask);
        killMobQuest = new Quest(taskList);
    }
    void Awake()
    {
        EnemyEvents.onEnemyKilled += MobKilled;
        NPCEvents.onStartQuest += InitializeQuest;
    }
    void MobKilled()
    {
        questTask.KillOne();
        if(killMobQuest.Completed())
        {
            print("all done");
        }
    }
	
}
