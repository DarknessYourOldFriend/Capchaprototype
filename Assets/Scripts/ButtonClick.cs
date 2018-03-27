using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

	Button submitButton;
	public bool submitted = false;

	public Sprite retryImage;
	public Sprite continueImage;


//if (GameObject.Find("name of the gameobject holding the script with the bool").GetComponent<name of the script holding the bool>().IsLightOn)

	void Start () {
		submitButton = GetComponent<Button> ();
		submitButton.GetComponentInChildren<Text>().text = "Submit";
		submitButton.onClick.AddListener (Submit);
	}
		
	public void Submit(){
		//Change the buttons depending on the answer / Retry or Continue
		if (submitted == false) {
			submitted = true;
			if (GameObject.Find ("GameManager").GetComponent<GameManager> ().selectedAllTargets == true) {
				submitButton.GetComponentInChildren<Text>().text = "";
				submitButton.image.sprite = continueImage;
			} else {
				submitButton.GetComponentInChildren<Text>().text = "";
				submitButton.image.sprite = retryImage;	
			}
		} else {
			if (GameObject.Find ("GameManager").GetComponent<GameManager> ().selectedAllTargets == true) {
				Application.LoadLevel(Application.loadedLevel + 1);
			} else {
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
			}
		}
	}
}

