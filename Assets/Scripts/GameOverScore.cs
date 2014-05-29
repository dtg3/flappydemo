using UnityEngine;
using System.Collections;

public class GameOverScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guiText.text = "Score: " + Score.score;
	}
}
