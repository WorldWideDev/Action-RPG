using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roboter : MonoBehaviour {

	int HP;
	public string robotName;
	int nearDeath = 10;

	Animator roboAnim;

	void Awake()
	{
		roboAnim = GetComponent<Animator>();
		PlayerEvents.onPlayerSlap += GotSlapped;
		Robot thisRobot = new Robot();
		HP = thisRobot.Heath;
		print(HP);
	}

	void GotSlapped(GameObject target, PlayerEvents.AttackEvent e)
	{
		Roboter thisRoboter = target.GetComponent<Roboter>();
		if(thisRoboter == this)
		{
			print(robotName + " got slapped with the force of " + e.Dmg);
			TakeDamage(e.Dmg);
		}
	}

	void TakeDamage(int dmg)
	{
		HP -= dmg;
		print(robotName + " has: " + HP + " remaining HP");
		if(HP <= nearDeath)
		{
			roboAnim.SetBool("isHurt", true);
		}
		if(HP <= 0)
		{
			EnemyEvents.EnemyKilled();
			Destroy(gameObject);
		}
	}
}
