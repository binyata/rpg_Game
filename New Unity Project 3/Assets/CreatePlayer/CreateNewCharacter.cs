using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {
	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	private string playerName = "Enter Name";
	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){

				playerName = GUILayout.TextArea (playerName, 15);
				isMageClass = GUILayout.Toggle (isMageClass, "Mage Class");
				isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");
				if (GUILayout.Button ("Create")) {
						if (isMageClass) {
								newPlayer.PlayerClass = new BaseMageClass ();
						} else if (isWarriorClass) {
								newPlayer.PlayerClass = new BaseWarriorClass ();
						}


						newPlayer.PlayerLevel = 1;
						newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
						newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
						newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
						newPlayer.Strength = newPlayer.PlayerClass.Strength;
						newPlayer.PlayerName = playerName;
						StoreNewPlayerInfo ();
						SaveInformation.SaveAllInformation ();
						Debug.Log ("Player Name: " + newPlayer.PlayerName);
						Debug.Log ("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
						Debug.Log ("Player Level: " + newPlayer.PlayerLevel);
						Debug.Log ("Player Stamina: " + newPlayer.Stamina);
						Debug.Log ("Player Endurance: " + newPlayer.Endurance);
						Debug.Log ("Player Intellect: " + newPlayer.Intellect);
						Debug.Log ("Player Strength: " + newPlayer.Strength);

				
						
				}


		if (GUILayout.Button ("Load")) {
			Application.LoadLevel ("ryan1");
		}
		}

	// New info will be placed into gameinformation object - to save properly
	private void StoreNewPlayerInfo(){

		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerLevel = newPlayer.PlayerLevel;
		GameInformation.Stamina = newPlayer.PlayerClass.Stamina;
		GameInformation.Endurance = newPlayer.PlayerClass.Endurance;
		GameInformation.Intellect = newPlayer.PlayerClass.Intellect;
		GameInformation.Strength = newPlayer.PlayerClass.Strength;
	

	}
}
