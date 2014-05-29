using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {

	float flapSpeed = 100f;
	float forwardSpeed = 1f;

	bool didFlap = false;
	public bool dead = false;

	float deathCooldown;
	public bool iddqd = false;

	Animator animator;

	public AudioClip[] sfx;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator>();
		if (CharSelBlue.overBlue)
			animator.SetTrigger ("Blue");
		if (CharSelRed.overRed)
			animator.SetTrigger ("Red");
		if (CharSelGreen.overGreen)
			animator.SetTrigger ("Green");
	}

	// Do Graphic and Updates Here
	void Update() {
		if(dead) {
			deathCooldown -= Time.deltaTime;
			if(deathCooldown <= 0) {
				if(Input.GetKeyDown(KeyCode.Space)) {
					//Application.LoadLevel(Application.loadedLevel);
					Application.LoadLevel("GameOver");
				}
			}
		}
		else {
			if(Input.GetKeyDown(KeyCode.Space)) {
				audio.PlayOneShot(sfx[0]);
				didFlap = true;
			}
		}
	}

	// Do physics engine updates here
	void FixedUpdate () {

		if (dead)
			return;

		rigidbody2D.AddForce (Vector2.right * forwardSpeed);

		if (didFlap) {
			rigidbody2D.AddForce (Vector2.up * flapSpeed);
			animator.SetTrigger("DoFlap");
			didFlap = false;
		}

		if (rigidbody2D.velocity.y > 0) {
			transform.rotation = Quaternion.Euler(0, 0, 0);
		}
		else {
			float angle = Mathf.Lerp(0, -90, (-rigidbody2D.velocity.y / 3f));
			transform.rotation = Quaternion.Euler(0, 0, angle);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (!iddqd) {
			audio.PlayOneShot(sfx[1]);
			if (!dead) {
				animator.SetTrigger ("Death");
				dead = true;
				deathCooldown = 0.5f;
			}
		}
	}
}
