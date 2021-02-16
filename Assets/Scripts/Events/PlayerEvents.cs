using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerEvents : MonoBehaviour {

	public class AttackEvent : EventArgs
	{
		public int Dmg;
		public AttackEvent(int dmg)
		{
			Dmg = dmg;
		} 
	}
	public delegate void AttackHandler(GameObject target, AttackEvent e);
	public delegate void AttemptAttackHandler(int dmg);
	public static event AttackHandler onPlayerSlap;
	public static event AttemptAttackHandler onAttackAttempt;

	public static void AttemptAttack(int dmg)
	{
		if(onAttackAttempt != null)
		{
			onAttackAttempt(dmg);
		}
	}

	public static void Slap(GameObject target, int dmg)
	{
		if(onPlayerSlap != null)
		{
			onPlayerSlap(target, new AttackEvent(dmg));
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
