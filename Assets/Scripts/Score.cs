using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public static int score = 0;
	public static int highScore = 0;

	static Score instance;

	static public void AddPoint() {
		if (instance.bird.dead)
			return;

		++score;

		if (score > highScore) {
			highScore = score;
		}
	}

	BirdMovement bird;

	void Start() {
		instance = this;
		GameObject player_go = GameObject.FindGameObjectWithTag ("PBird");
		if (player_go == null) {
			Debug.LogError("Could not find object with tag 'PBird'!");
		}
		bird = player_go.GetComponent<BirdMovement> ();
		score = 0;
		highScore = PlayerPrefs.GetInt ("highscore", 0);
	}

	void OnDestroy() {
		instance = null;
		PlayerPrefs.SetInt ("highscore", highScore);
	}

	// Update is called once per frame
	void Update () {
		guiText.text = "Score: " + score + "\nHigh Score: " + highScore;
	}
}
