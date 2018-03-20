using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

	Button submitButton;
	public bool submitted = false;

	//if (GameObject.Find("name of the gameobject holding the script with the bool").GetComponent<name of the script holding the bool>().IsLightOn)


	// Use this for initialization
	void Start () {
		submitButton = GetComponent<Button> ();
		submitButton.onClick.AddListener (Submit);

	}
		
	public void Submit(){
		if (GameObject.Find ("GameManager").GetComponent<GameManager> ().selectedAllTargets == true) {
			Debug.Log ("You selected all the ducks!");
		}
		else {
			Debug.Log ("You DIDN'T selected all the ducks!");
		}
//		submitted = true;
//		SceneManager.LoadScene("Level02");
	}

	public void onClick_false(){

//		if (Input.GetKeyDown (KeyCode.Space)) {
//			submitted = true;
////			Application.LoadLevel(Application.loadedLevel);
//		}

	}


}

