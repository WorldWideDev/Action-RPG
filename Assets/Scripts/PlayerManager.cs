using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	public Slapper player = new Slapper("Devon");
	public static int test1 = 0;
	public int test2 = 1;

	private static PlayerManager instance = null;
	public static PlayerManager Instance
	{
		get 
		{
			if(instance == null)
			{
				instance = new GameObject("PlayerManager").AddComponent<PlayerManager>();
			}
			return instance;			
		}
	}

	void Awake()
	{
		if(instance)
			Destroy(gameObject);
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
	}
}
