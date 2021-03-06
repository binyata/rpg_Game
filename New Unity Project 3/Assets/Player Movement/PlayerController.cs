﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	// tutorial 18

	public float rotateSpeed;
	public float forwardSpeed;
	private CharacterController playerController;

	// Use this for initialization
	void Start () {
		playerController = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space") && playerController.isGrounded) {
			playerController.Move (Vector3.up);
			//allow only certain actions if char is on ground
				}

		transform.Rotate (0, Input.GetAxis ("Horizontal") * rotateSpeed, 0);
		// vector 3 = (0,0,0) = (x,y,z)
		Vector3 forward = transform.TransformDirection (Vector3.forward);
		float speed = forwardSpeed * Input.GetAxis ("Vertical");
		playerController.SimpleMove (speed * forward);
	}
}
