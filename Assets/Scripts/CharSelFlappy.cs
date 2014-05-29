using UnityEngine;
using System.Collections;

public class CharSelFlappy : MonoBehaviour {

	public static bool overFlappy = false;
	Animator animator;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponentInChildren<Animator>();
		overFlappy = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (overFlappy) {
			guiText.color = Color.yellow;
			animator.SetTrigger("DoFlap");
		}
		else {
			guiText.color = Color.white;
		}
	}

	void OnMouseOver ()
	{
		overFlappy = true;
	}
	
	void OnMouseExit ()
	{
		overFlappy = false;
	}

	void OnMouseDown () {
		Application.LoadLevel ("Gameplay");
	}
}
