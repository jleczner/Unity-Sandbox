using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(PlayerController))]

public class PlayerScript : MonoBehaviour {

	PlayerController playerController;
	Camera viewCamera;
	float moveSpeed = 5;

	void Start() {
		playerController = GetComponent<PlayerController>();
		viewCamera = Camera.main;
	}
	
	void Update() {
		updateVision();
		updateMovement();
	}

	void updateMovement() {
		Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		Vector3 moveVelocity = moveInput.normalized * moveSpeed;
		playerController.setVelocity(moveVelocity);
	}

	void updateVision() {
		Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
		Plane groundPlane = new Plane (Vector3.up, Vector3.zero);
		float rayDistance;

		if (groundPlane.Raycast(ray, out rayDistance)) {
			Vector3 point = ray.GetPoint(rayDistance);
			Debug.DrawLine(ray.origin, point);
			playerController.lookAt(point);
		}
	}
}
