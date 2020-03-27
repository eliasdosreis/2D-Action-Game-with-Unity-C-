using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed;
	private Animator anim;
	private Rigidbody2D rigid;

	[SerializeField]
	private Vector2 moveAmount;

	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void Update(){
		moveAmount = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));

		if (moveAmount != Vector2.zero) {
			anim.SetBool ("isRunning", true);
		} else {
			anim.SetBool ("isRunning", false);
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		
		Vector2 inputMove = moveAmount.normalized * speed;

		rigid.MovePosition (rigid.position + inputMove * Time.fixedDeltaTime);
	}
}
