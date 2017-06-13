using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody))]

public class PlayerController : MonoBehaviour {
	Rigidbody playerBody;
	Vector3 velocity;

	void Start() {
		playerBody = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate() {
		move();
	}

	public void move() {
		playerBody.MovePosition(playerBody.position + velocity * Time.fixedDeltaTime);
	}

	public void setVelocity(Vector3 velocity) {
		this.velocity = velocity;
	}

	public void lookAt(Vector3 point) {
		Vector3 correctedPoint = new Vector3 (point.x, transform.position.y, point.z);
		transform.LookAt(correctedPoint);
	}
}
