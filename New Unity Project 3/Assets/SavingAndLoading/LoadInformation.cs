using UnityEngine;
using System.Collections;

public class LoadInformation {

	public static void LoadAllInformation(){
		GameInformation.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInformation.Stamina   = PlayerPrefs.GetInt ("STAMINA");
		// Serialize basecharacter
		GameInformation.Endurance = PlayerPrefs.GetInt ("ENDURANCE");
		GameInformation.Intellect = PlayerPrefs.GetInt ("INTELLECT");
		GameInformation.Strength  = PlayerPrefs.GetInt ("STRENGTH");
	

		if (PlayerPrefs.GetString("EQUIPMENTITEM1") != null){
			GameInformation.EquipmentOne = (BaseEquipment)PPSerialization.Load("EQUIPMENTITEM1");
			
		}

	}
}
