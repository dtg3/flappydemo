using UnityEngine;
using System.Collections;

public class BGLooperScript : MonoBehaviour {

	int numBGPanels = 6;

	float pipeMax = 0.5947376f;
	float pipeMin = -0.259855f;

	void Start() {
		GameObject[] pipes = GameObject.FindGameObjectsWithTag ("Pipe");

		foreach (GameObject pipe in pipes) {
			Vector3 pos = pipe.transform.position;
			pos.y = Random.Range (pipeMin, pipeMax);
			pipe.transform.position = pos;
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {

		float widthOfBGObject = ((BoxCollider2D)collider).size.x;
		Vector3 pos = collider.transform.position;
		pos.x += widthOfBGObject * numBGPanels;

		if (collider.tag == "Pipe") {
			pos.y = Random.Range (pipeMin, pipeMax);	
		}

		collider.transform.position = pos;
	}
}
