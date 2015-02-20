using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed = 7.0f;

	
	// Update is called once per frame
	void Update () {
		// going left to right or right to left -- cant use for input buttons
		if (Input.GetKey ("w")) {
			transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
			Debug.Log("Pressing W Key"); 
				}
		// space bars -- like jump use for fire
		if (Input.GetKey ("s")) {
			transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);

		}


		if (Input.GetKey ("d")) {
			transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
			
		}


		if (Input.GetKey ("a")) {
		//	transform.Rotate(Vector3.down * moveSpeed * Time.deltaTime);
		// transform.down(Vector3.zero * Time.deltaTime);
			transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
			
		}
	

		if (Input.GetButtonDown ("Fire1")) {
			Debug.Log("Pressing Fire1 Key"); 
		}


		// 1 = right mouse click  0 = left mouse click
		if(Input.GetMouseButton(0)){
			// sprint example: moveSpeed = 20;
			Debug.Log("Mouse Button");
		}

						
	}
}
