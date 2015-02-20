using UnityEngine;
using System.Collections;
[System.Serializable]
public class BaseWarriorClass : BaseCharacterClass {

	// Use this for initialization
	public BaseWarriorClass() {
		CharacterClassName = "Warrior";
		CharacterClassDescription = "A strong and powerful hero.";
		Stamina = 15;
		Endurance = 12;
		Strength = 14;
		Intellect = 10;
	}
	

}
