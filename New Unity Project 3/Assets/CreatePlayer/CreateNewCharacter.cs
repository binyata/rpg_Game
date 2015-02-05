using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {
	private BasePlayer newPlayer;
	private bool isMageClass;
	private bool isWarriorClass;
	// Use this for initialization
	void Start () {
		newPlayer = new BasePlayer ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		isMageClass = GUILayout.Toggle (isMageClass, "Mage Class");
		isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");
		if(GUILayout.Button ("Create")){
			if(isMageClass){
				newPlayer.PlayerClass = new BaseMageClass();
			}else if(isWarriorClass){
				newPlayer.PlayerClass = new BaseWarriorClass();
			}
			newPlayer.PlayerLevel = 1;
			newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
			newPlayer.Endurance = newPlayer.PlayerClass.Endurance;
			newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
			newPlayer.Strength = newPlayer.PlayerClass.Strength;

			Debug.Log ("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
			Debug.Log ("Player Level: " + newPlayer.PlayerLevel);
			Debug.Log ("Player Stamina: " + newPlayer.Stamina);
			Debug.Log ("Player Endurance: " + newPlayer.Endurance);
			Debug.Log ("Player Intellect: " + newPlayer.Intellect);
			Debug.Log ("Player Strength: " + newPlayer.Strength);
		}
		}
}
