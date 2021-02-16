using UnityEngine;
public class Slapper : Hero 
{
	public Slapper(string name) : base (name)
	{
		CharacterClassName = "Super Slapper";
		CharacterClassDesc = "THERE WILL BE SLAPS";
		Health = 30;
		Intelligence = 1;
		Strength = 25;
	}

	public int SlapPower
	{
		get { return (int)Mathf.Floor(Strength/5); }
	}
}
