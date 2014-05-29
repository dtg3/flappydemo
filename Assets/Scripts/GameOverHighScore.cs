using UnityEngine;
using System.Collections;

public class GameOverHighScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guiText.text = "High Score: " + Score.highScore;
	}
}
