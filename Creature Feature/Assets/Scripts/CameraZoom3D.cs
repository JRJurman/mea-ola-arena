using UnityEngine;
using System.Collections;

public class CameraZoom3D : MonoBehaviour {

	// Game player objects
	public GameObject ball;
	public GameObject player1;
	public GameObject player2;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


		// Distance between players 
		Vector3 playerDistance = player1.transform.position - player2.transform.position;

		// Value of the distance
		float playerMag = playerDistance.magnitude;

		// Set Camera zoom
		Camera.main.fieldOfView = Mathf.Min (playerMag, 90);

		Camera.main.transform.LookAt (ball.transform.position);

	}
}
