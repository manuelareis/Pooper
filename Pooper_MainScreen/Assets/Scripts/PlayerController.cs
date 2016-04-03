using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float maxSpeed = 10f;
	 Rigidbody2D rb;

	Animator anim;

	bool grounded = false;
	public Transform groundChek;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 75.0f;
	public float forwardMovementSpeed = 3f;

	void Start () {
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	void Update(){
	}

	void FixedUpdate () {

		bool jumpActive = Input.GetButton ("Fire1");

		if (jumpActive) {
			rb.AddForce(new Vector2(0, jumpForce));
		}

		grounded = Physics2D.OverlapCircle (groundChek.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		/*Vector2 newVelocity = rb.velocity;
		newVelocity.x = forwardMovementSpeed;
		rb.velocity = newVelocity;
         * */

	}

}
