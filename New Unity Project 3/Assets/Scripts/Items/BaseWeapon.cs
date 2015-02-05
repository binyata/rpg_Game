using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem {	//BaseWeapon <- BaseStatItem <- BaseItem
	
	public enum WeaponTypes{
		SWORD,
		STAFF,
		DAGGER,
		BOW,
		SHIELD,
		POLEARM
	}
	private WeaponTypes weaponType;
	private int spellEffectID;
	
	public WeaponTypes WeaponType{
		get{return weaponType;}
		set{weaponType = value;}
	}
	public int SpellEffectID{
		get{return spellEffectID;}
		set{spellEffectID = value;}
	}
}