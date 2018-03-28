using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonGameOver : MonoBehaviour {
	[SerializeField] Button buttonGameOver;
	// Use this for initialization
	void Start () 
	{
		buttonGameOver = GetComponent<Button> ();
		buttonGameOver.onClick.AddListener (SubmitGameOver);

		Debug.Log("Submiioiooit");

	}
		

	public void SubmitGameOver() 
	{
		Debug.Log("Submit");

		SceneManager.LoadScene ("Level06");
	}

}
