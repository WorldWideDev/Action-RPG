public class Caster : Hero {

	public Caster(string playerName) : base(playerName)
	{
		CharacterClassName = "Master Caster";
		CharacterClassDesc = "Casting da spellz";
		Health = 15;
		Intelligence = 30;
		Strength = 3;
	}
}
