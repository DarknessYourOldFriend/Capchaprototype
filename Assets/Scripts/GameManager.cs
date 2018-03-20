using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public bool selectedAllTargets = true;
	public GameObject applePrefab;
	public GameObject duckPrefab;
	public GameObject brushPrefab;
	public string targetTag;

	public float tileWidth = 5f;
	public float tileHeight = 3f;
	int index;

	public string levelFile = "level1.txt";

	public GameObject[] buttons;

	// Use this for initialization
	void Start () {



//		index = Random.Range (0, buttons.Length);



		// Reading the file into string.
		string levelString = File.ReadAllText(Application.dataPath + Path.DirectorySeparatorChar + levelFile);

		// Splitting the string into lines.
		string[] levelLines = levelString.Split('\n');
		int width = 0;
		// Iterating over the lines.
		for (int row = 0; row < levelLines.Length; row++) {
			string currentLine = levelLines[row];
			width = currentLine.Length;
			// Iterating over all the chars in a line.
			for (int col = 0; col < currentLine.Length; col++) {
				char currentChar = currentLine[col];
				if (currentChar == 'd') {
					index = Random.Range (0, buttons.Length);
					GameObject duckObj = Instantiate(duckPrefab);
					duckObj.transform.parent = transform;
					duckObj.transform.position = new Vector3(col*tileWidth, -row*tileHeight, 0);
				}
				else if (currentChar == 'a') {

					GameObject appleObj = Instantiate(applePrefab);
					appleObj.transform.parent = transform;
					appleObj.transform.position = new Vector3(col*tileWidth, -row*tileHeight, 0);
				}
				else if (currentChar == 'b') {

					if (Random.value <= 0.5f) {
						GameObject brushObj = Instantiate(brushPrefab);
						brushObj.transform.parent = transform;
						brushObj.transform.position = new Vector3(col*tileWidth, -row*tileHeight, 0);
					}
				}
			}
		}
		buttons = GameObject.FindGameObjectsWithTag("button");
//		Debug.Log (buttons.Length);
//		float myX = -(width*tileWidth)/2f + tileWidth/2f;
//		float myY = (levelLines.Length*tileHeight)/2f - tileHeight/2f;
//		transform.position = new Vector3(myX, myY, 0);

		// If we were centering the level by moving the camera
		//float cameraY = -(levelLines.Length*tileHeight)/2f + tileHeight/2f;
		//float cameraX = (width*tileWidth)/2f - tileWidth/2f;
		//Camera.main.transform.position = new Vector3(cameraX, cameraY, -10);

	}
	
	// Update is called once per frame
	void Update () {

		checkButtons ();
		
	}

	public void checkButtons() {


		foreach (GameObject buttonObj in buttons) {
			string buttonTag = buttonObj.GetComponent<ImageTag>().ButtonImageTag;
			bool buttonIsSelected = buttonObj.GetComponent<ImageTag> ().isSelected;

			if (buttonTag == targetTag) {
				if (buttonIsSelected == true) {
					// We found a button that's a duck that we didn't select, therefore we have not selected all ducks
					selectedAllTargets = true;
				} 
				else {
					selectedAllTargets = false;
					return;
				}
			}
				
			if (buttonTag != targetTag) {
				if (buttonIsSelected == true) {
					// We found a button that's NOT a duck that we DID select, therefore we have not selected ONLY the ducks.
					selectedAllTargets = false;
					return;
				} 
				else {
					selectedAllTargets = true;
				}

			}

//			Debug.Log ("selectedAllDucks =" + selectedAllTargets);

		}

//		foreach (GameObject buttonObj in buttons) {
//			string buttonTag = buttonObj.GetComponent<ImageTag>().ButtonImageTag;
//			bool buttonIsSelected = buttonObj.GetComponent<ImageTag>().isSelected;
//			if (buttonTag == "duck" && buttonIsSelected == false) {
//				Debug.Log ("First IF");
//				// We found a button that's a duck that we didn't select, therefore we have not selected all ducks
//				selectedAllDucks = false;
//			}
//			if (buttonTag != "duck" && buttonIsSelected == true) {
//				// We found a button that's NOT a duck that we DID select, therefore we have not selected ONLY the ducks.
//				selectedAllDucks = false;
//
//				Debug.Log ("Second IF");
//
//			} 
//
//			if (buttonTag == "duck" && buttonIsSelected == true) {
//				selectedAllDucks = true;
//			}
//		}
//		Debug.Log ("selectedAllDucks is " + selectedAllTargets);

	}

}
