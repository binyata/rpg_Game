using UnityEngine;
using System.Collections;

public class RewardExperiencePoints : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	private int DetermineXPForNextLevel(int playerLevel){

		playerLevel += 1;
		int levels = 50;
		float xpLevel1 = 500.0f;
		float xpLevel50 = 400000.0f;
		float temp1 = Mathf.Log (xpLevel50 / xpLevel1);
		float b = temp1 / (levels - 1);
		float temp2 = (Mathf.Exp (b) - 1);
		float a = (xpLevel1) / temp2;
		int oldxp = (int)(a * Mathf.Exp ((float)b * (playerLevel - 1)));
		int newxp = (int)(a * Mathf.Exp ((float)b * playerLevel));
		int temp = newxp - oldxp;
		temp = (int)Mathf.Round ((float)temp / 10.0f) * 10;
		return temp;


		}
}
