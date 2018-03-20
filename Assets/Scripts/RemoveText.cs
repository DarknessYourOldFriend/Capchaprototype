using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveText : MonoBehaviour {

	GameObject submitted;
	bool submittedRight;

	// Use this for initialization
	void Start () {
		submitted = GameObject.Find ("GameManager");
		submittedRight = submitted.GetComponent<ButtonClick> ().submitted;

	}
	
	// Update is called once per frame
	void Update () {
		if (submittedRight == true) {
			gameObject.SetActive(false);
		}
		
	}
}
