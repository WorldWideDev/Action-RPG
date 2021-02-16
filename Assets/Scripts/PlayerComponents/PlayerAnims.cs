using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnims : MonoBehaviour {

	Animator anim;
	Animation melee;
	PlayerCombat pc;

	void Awake()
	{
		PlayerEvents.onAttackAttempt += TryAttack;
	}
	void Start () {
		anim = GetComponent<Animator>();
		pc = GetComponent<PlayerCombat>();
	}

	public void TryAttack(int dmg)
	{
		anim.SetTrigger("mMelee");
		pc.isSlapping = true;
	}

	public void SetSlapToFalse()
	{
		print("slap to false");
		pc.isSlapping = false;
		pc.alreadySlapped = false;
	}

	void OnDestroy()
	{
		PlayerEvents.onAttackAttempt -= TryAttack;
	}
	
}
