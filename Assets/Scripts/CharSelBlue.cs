using UnityEngine;
using System.Collections;

public class CharSelBlue : MonoBehaviour {

	public static bool overBlue;
	Animator animator;
	GUIText text;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator>();
		overBlue = false;
		animator.SetTrigger ("Blue");
	}
	
	// Update is called once per frame
	void Update () {
		if (overBlue) {
			animator.SetTrigger("DoFlap");
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
