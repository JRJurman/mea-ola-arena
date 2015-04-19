using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour {

	public AnimationClip idleAnimation;
	public AnimationClip rollAnimation;
	public AnimationClip attackAnimation;

	public float rollMaxAnimationSpeed = 1f;

	private Animation anim;

	enum CharacterState {

		idle = 0,
		roll = 1,
		attack = 2,
	}

	private CharacterState charState;

	public float rollSpeed = 6.0f;


	// Use this for initialization
	void Start () {
	
		anim = GetComponent<Animation> ();

	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
