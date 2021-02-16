using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEvents : MonoBehaviour {

	// public delegate void WasAttackedHandler
	public delegate void EnemyKilledHandler();
	public static event EnemyKilledHandler onEnemyKilled;

	public static void EnemyKilled()
	{
		if(onEnemyKilled != null)
		{
			onEnemyKilled();
		}
	}
}
