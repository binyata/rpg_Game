﻿using UnityEngine;
using System.Collections;

public class BasePlayer : MonoBehaviour {

	private string playerName;
	private int playerLevel;
	private BaseCharacterClass playerClass;
	private int stamina;
	private int endurance;
	private int intellect;
	private int strength;
	private int currentXP;
	private int requiredXP;


	public int CurrentXP{ get; set; }
	public int RequiredXP{ get; set; }

	// public string PlayerName{get;set;}
	public string PlayerName{
		get{ return playerName;}
		set{ playerName = value;}
	}

	public int PlayerLevel{
		get{ return playerLevel;}
		set{ playerLevel = value;}
	}

	public BaseCharacterClass PlayerClass{
		get{ return playerClass;}
		set{ playerClass = value;}
	}

	public int Stamina{
		get{ return stamina;}
		set{ stamina = value;}
	}

	public int Endurance{
		get{ return endurance;}
		set{ endurance = value;}
	}

	public int Intellect{
		get{ return intellect;}
		set{ intellect = value;}
	}

	public int Strength{
		get{ return strength;}
		set{ strength = value;}
	}
}
