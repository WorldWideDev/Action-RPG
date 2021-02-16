using System.Collections.Generic;
interface ICompleteable
{
	bool Completed();
}

public abstract class Requirement : ICompleteable
{

	public abstract bool Completed();
}

public class KillMobsRequirement : Requirement
{
	int mobsRemaining;
	public KillMobsRequirement(int numMobs)
	{
		mobsRemaining = numMobs;
	}

	public void KillOne()
	{
		mobsRemaining--;
	}

	public override bool Completed()
	{
		if (mobsRemaining > 0) { return false; }
		else { return true; }
	}
}
public class Quest : ICompleteable 
{
	List<Requirement> Requirements;
	public Quest(List<Requirement> requirements)
	{
		Requirements = requirements;
	}

	public bool Completed()
	{
		foreach (Requirement r in Requirements)
		{
			if(!r.Completed())
				return false;

		}
		return true;
	}
}
