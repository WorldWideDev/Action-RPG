public class Hero {

	string playerName;
	string characterClassName;
	string characterClassDesc;
	int health;
	int strength;
	int intelligence;

	int experience;

	public Hero(string playerName)
	{
		PlayerName = playerName;
		Experience = 0;
	}

	public string PlayerName
	{
		get{ return playerName; }
		set{ playerName = value; }		
	}

	public string CharacterClassName
	{
		get { return characterClassName; }
		set { characterClassName = value; }
	}

	public string CharacterClassDesc
	{
		get { return characterClassDesc; }
		set { characterClassDesc = value; }
	}

	public int Health
	{
		get { return health; } 
		set { health = value; }
	}

	public int Strength
	{
		get { return strength; }
		set { strength = value; }
	}

	public int Intelligence
	{
		get { return intelligence; }
		set { intelligence = value; }
	}

	public int Experience
	{
		get { return experience; }
		set { experience = value; }
	}

	
}
