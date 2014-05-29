using UnityEngine;
using System.Collections;

public class GroundMover : MonoBehaviour {

	Rigidbody2D player;

	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag ("PBird");
		if (player_go == null) {
			Debug.LogError("Couldn't find and object with tag 'PBird'!");
			return;
		}
		
		player = player_go.rigidbody2D;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float vel = player.velocity.x * .9f;
		transform.position = transform.position + Vector3.right * vel * Time.deltaTime;
	}
}
