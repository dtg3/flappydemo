using UnityEngine;
using System.Collections;

public class CharSelGreen : MonoBehaviour {

	public static bool overGreen = false;
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator>();
		overGreen = false;
		animator.SetTrigger ("Green");
	}
	
	// Update is called once per frame
	void Update () {
		if (overGreen) {
			guiText.color = Color.green;
			animator.SetTrigger("DoFlap");
		}
		else {
			guiText.color = Color.white;
		}
	}

	void OnMouseOver ()
	{
		overGreen = true;
	}
	
	void OnMouseExit ()
	{
		overGreen = false;
	}

	void OnMouseDown () {
		overGreen = true;
		Application.LoadLevel ("Gameplay");
	}
}
