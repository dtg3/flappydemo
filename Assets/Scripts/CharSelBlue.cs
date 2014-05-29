using UnityEngine;
using System.Collections;

public class CharSelBlue : MonoBehaviour {

	public static bool overBlue;
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator>();
		overBlue = false;
		animator.SetTrigger ("Blue");
	}
	
	// Update is called once per frame
	void Update () {
		if (overBlue) {
			guiText.color = Color.blue;
			animator.SetTrigger("DoFlap");
		}
		else {
			guiText.color = Color.white;
		}
	}

	void OnMouseEnter ()
	{
		overBlue = true;
	}
	
	void OnMouseExit () 
	{
		overBlue = false;
	}

	void OnMouseDown () {
		overBlue = true;
		Application.LoadLevel ("Gameplay");
	}
}
