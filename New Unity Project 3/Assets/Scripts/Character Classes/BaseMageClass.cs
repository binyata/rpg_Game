using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {
	
	// Use this for initialization
	public BaseMageClass() {
		CharacterClassName = "Mage";
		CharacterClassDescription = "A wise wizard, can cast spells.";
		Stamina = 12;
		Endurance = 14;
		Strength = 10;
		Intellect = 15;
	}
	
	
}
