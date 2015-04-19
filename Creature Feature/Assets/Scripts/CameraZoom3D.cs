using UnityEngine;
using System.Collections;

public class CameraZoom3D : MonoBehaviour {

	// Game player objects
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
		Camera.main.fieldOfView = playerMag / 2;
//
//		float targetX = player1.transform.position.x + (playerDistance.x / 2);
//		float targetY = player1.transform.position.y + (playerDistance.y / 2);
//		Vector3 targetVector = new Vector3 (transform.position.x, targetY);
//
//		//Set so the camera will follow the players
//		Quaternion lookAtRotation = Quaternion.LookRotation (targetVector - transform.position);
//		Camera.main.transform.rotation = Quaternion.Lerp(transform.rotation, lookAtRotation, 1.5f * Time.deltaTime);
//	
	}
}
