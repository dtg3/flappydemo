using UnityEngine;
using System.Collections;

public class TitleTransition : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space))
		{
			Application.LoadLevel("CharSelect");
		}
	}
}
