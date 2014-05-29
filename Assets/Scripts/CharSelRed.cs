using UnityEngine;
using System.Collections;

public class CharSelRed : MonoBehaviour {

	public static bool overRed = false;
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator>();
		overRed = false;
		animator.SetTrigger ("Red");
	}
	
	// Update is called once per frame
	void Update () {
		if (overRed) {
			guiText.color = Color.red;
			animator.SetTrigger("DoFlap");
		}
		else {
			guiText.color = Color.white;
		}
	}

	void OnMouseOver ()
	{
		guiText.color = Color.red;
		overRed = true;
	}

	void OnMouseDown () {
		overRed = true;
		Application.LoadLevel ("Gameplay");
	}
	
	void OnMouseExit ()
	{
		guiText.color = Color.white;
		overRed = false;
	}
}
