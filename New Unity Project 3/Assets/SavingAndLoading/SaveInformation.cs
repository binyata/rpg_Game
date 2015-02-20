using UnityEngine;
using System.Collections;

public class SaveInformation {

	public static void SaveAllInformation(){
		PlayerPrefs.SetInt ("PLAYERLEVEL", GameInformation.PlayerLevel);
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName);
		// Serialize basecharacter
		PlayerPrefs.SetInt ("STAMINA", GameInformation.Stamina);
		PlayerPrefs.SetInt ("ENDURANCE", GameInformation.Endurance);
		PlayerPrefs.SetInt ("INTELLECT", GameInformation.Intellect);
		PlayerPrefs.SetInt ("STRENGTH", GameInformation.Strength);

		if (GameInformation.EquipmentOne != null) {
						PPSerialization.Save ("EQUIPMENTITEM1", GameInformation.EquipmentOne);

				}
		Debug.Log("SAVED ALL INFORMATION");

	}
}
