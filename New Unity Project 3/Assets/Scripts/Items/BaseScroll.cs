using UnityEngine;
using System.Collections;
[System.Serializable]
public class BaseScroll : BaseItem {
	
	private int spellEffectID;
	
	public int SpellEffectID{
		get{return spellEffectID;}
		set{spellEffectID = value;}
	}
}