using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Vector3 moveVector;
	private CharacterController charControl;
	private float moveSpeed = 8;
	private float jumpPower = 15;
	private float gravity = 30;

	// Use this for initialization
	void Start () {

		charControl = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () {

		moveVector.x = Input.GetAxis ("LeftJoystickX") * moveSpeed;
		moveVector.z = -(Input.GetAxis ("LeftJoystickY") * moveSpeed);

		System.Console.WriteLine (moveVector);

			transform.forward = Vector3.Normalize (new Vector3 (-(Input.GetAxis ("LeftJoystickX")), 0f, 
		                                                   Input.GetAxis ("LeftJoystickY")));

		// Jump Controls
		if (charControl.isGrounded) {

			moveVector.y = 0;

			if (Input.GetButtonDown("A")) {
				moveVector.y = jumpPower;
			}
		}

		if (Input.GetButtonDown ("B")) {
			// Where attack logic will go
		}

		moveVector.y -= gravity * Time.deltaTime;
		charControl.Move (moveVector * Time.deltaTime);

	}
}
