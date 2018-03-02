using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour {

	public GameObject[] buttons;
	
	public GameObject applePrefab;
	public GameObject duckPrefab;
	public GameObject brushPrefab;

	public float tileWidth = 5f;
	public float tileHeight = 3f;

	public string levelFile = "level1.txt";

	public GameObject[] buttons;

	// Use this for initialization
	void Start () {



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
					// Make a wall!
					GameObject duckObj = Instantiate(duckPrefab);
					duckObj.transform.parent = transform;
					duckObj.transform.position = new Vector3(col*tileWidth, -row*tileHeight, 0);
				}
				else if (currentChar == 'a') {
					// Make the player!
					GameObject appleObj = Instantiate(applePrefab);
					appleObj.transform.parent = transform;
					appleObj.transform.position = new Vector3(col*tileWidth, -row*tileHeight, 0);
				}
				else if (currentChar == 'b') {
					// We flip a coin
					if (Random.value <= 0.5f) {
						GameObject brushObj = Instantiate(brushPrefab);
						brushObj.transform.parent = transform;
						brushObj.transform.position = new Vector3(col*tileWidth, -row*tileHeight, 0);
					}
				}
			}
		}

//		float myX = -(width*tileWidth)/2f + tileWidth/2f;
//		float myY = (levelLines.Length*tileHeight)/2f - tileHeight/2f;
//		transform.position = new Vector3(myX, myY, 0);

		// If we were centering the level by moving the camera
		//float cameraY = -(levelLines.Length*tileHeight)/2f + tileHeight/2f;
		//float cameraX = (width*tileWidth)/2f - tileWidth/2f;
		//Camera.main.transform.position = new Vector3(cameraX, cameraY, -10);

		buttons = GameObject.FindGameObjectsWithTag ("button");

//		foreach (GameObject buttonObj in buttons) {
//			string buttonTag = buttonObj.GetComponents<ImageTag> ().ButtonImageTag;
//		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
