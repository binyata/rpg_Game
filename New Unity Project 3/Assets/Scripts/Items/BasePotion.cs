using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem {
	
	public enum PotionTypes{
		HEALTH,
		ENERGY,
		STRENGTH,
		INTELLECT,
		VITALITY,
		ENDURANCE,
		SPEED
		
	}
	
	private PotionTypes potionType;
	private int spellEffectID;
	
	public PotionTypes PotionType{
		get{return potionType;}
		set{potionType = value;}
	}
	
	public int SpellEffectID{
		get{return spellEffectID;}
		set{spellEffectID = value;}
	}
}