using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveText : MonoBehaviour {

	GameObject gameManager;
	ButtonClick submitted;

	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager");
		submitted = GameObject.Find ("SubmitButton").GetComponent<ButtonClick> ();
	}
	
	// Deactivate the question text
	void Update () {
		if (submitted.submitted == true) {
			gameObject.SetActive(false);
		}
		
	}
}
