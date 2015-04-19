using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Vector3 moveVector;
	private CharacterController charControl;
	private Animator anim;
	private float moveSpeed = 8;
	private float jumpPower = 15;
	private float gravity = 30;
	private Vector3 lastRotation;

	public int joystickNum;

	// Use this for initialization
	void Start () {

		charControl = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		string joystickString = joystickNum.ToString ();

		moveVector.x = Input.GetAxis ("LeftJoystickX_P" + joystickString) * moveSpeed;
		moveVector.z = -(Input.GetAxis ("LeftJoystickY_P" + joystickString) * moveSpeed);

		if (Input.GetAxis ("LeftJoystickX_P" + joystickString) == 0.0 && Input.GetAxis ("LeftJoystickY_P" + joystickString) == 0.0) {
			transform.forward = lastRotation;
		} else {
			transform.forward = Vector3.Normalize (new Vector3 (-(Input.GetAxis ("LeftJoystickX_P" + joystickString)), 0f, 
			                                                    Input.GetAxis ("LeftJoystickY_P" + joystickString)));
		}
		lastRotation = transform.forward;

		// Jump Controls
		if (charControl.isGrounded) {

			moveVector.y = 0;

			if (Input.GetButtonDown("A_P" + joystickString )) {
				moveVector.y = jumpPower;
			}
		}

		// Attack! Attack! Atttaaaaaaack!!!
		if (Input.GetButton("B_P" + joystickString)) {
			anim.SetBool ("attack", true);
		} 
		else {
			anim.SetBool("attack", false);
		}
	
		// Advanced Dodge Slide technique (Aerial mode available)
		if (Input.GetButton ("X_P" + joystickString)) {

			moveVector.x -= -3 * transform.forward.x * moveSpeed;
			moveVector.z -= -3 * transform.forward.z * moveSpeed;
		}


		moveVector.y -= gravity * Time.deltaTime;
		charControl.Move (moveVector * Time.deltaTime);

	}
}
