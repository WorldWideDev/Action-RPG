using UnityEngine;
public class Robot : Enemy
{
	public Robot()
	{
		Heath = 30;
	}

	public void TakeDamage(int dmg)
	{
		Heath -= dmg;
	}

	public void AssessDamage()
	{
		if(Heath <= 0)
		{
			Debug.Log("I am dead");
		}
	}
}