using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float barDisplay; 
	public float xPos, yPos;

	private Vector2 pos, size;

	public Texture2D emptyTex, fullTex;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		barDisplay = Time.time * 0.05f;    
	}

	void OnGui() {
		 
		// Draw background
		GUI.BeginGroup (new Rect (pos.x, pos.y, size.x, size.y));
		GUI.Box (new Rect (0, 0, size.x, size.y), emptyTex);

		//Draw filled-in
			GUI.BeginGroup (new Rect (0, 0, size.x * barDisplay, size.y));
				GUI.Box (new Rect (0, 0, size.x, size.y), fullTex);
			GUI.EndGroup ();
		GUI.EndGroup ();
	}
}
