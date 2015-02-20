using UnityEngine;
using System.Collections;

public static class IncreaseExperience {
	// tutorial 19
	private static int xpToGive;
	// progress/achievements/rank/rep
	public static void AddExperience(){
		// more xp on human player than CPU player
		xpToGive = GameInformation.PlayerLevel * 100;
		GameInformation.CurrentXP += xpToGive;
		CheckToSeeIfPlayerLeveled ();
		Debug.Log (xpToGive);
	}
	// For movement experience
	public static void AddExplorationExperienceFromBattleLoss(){

		xpToGive = GameInformation.PlayerLevel * 10;
		GameInformation.CurrentXP += xpToGive;
		CheckToSeeIfPlayerLeveled ();
		Debug.Log (xpToGive);
		}

	// lose XPfromDeath
	private static void CheckToSeeIfPlayerLeveled(){
		if (GameInformation.CurrentXP >= GameInformation.RequiredXP) {
			//Then level up the player
			//CREATE LEVEL UP SCRIPT
			//wolframAlpha.org
		}

	}


	/*
	 * 
	 * 
	 * For anyone working through these Tutorials:
Dan fixes the "An object reference is required to access non-static member" errors this script creates in the next Episode﻿
*/

}
