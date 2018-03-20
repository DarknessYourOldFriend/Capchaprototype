using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageTag : MonoBehaviour {

	public bool isSelected = false;
	public string ButtonImageTag;
	public GameObject selectedObj;
	public GameObject frame;

	
	// Update is called once per frame
	void OnMouseDown() {

		isSelectedRun ();
	}

	void isSelectedRun() {

		if (isSelected == false){
			isSelected = true;
			if (frame == null) {
				frame = Instantiate (selectedObj, this.gameObject.transform);
				frame.transform.localPosition = Vector3.zero;

			}
		}
		else {
			isSelected = false;
			if (frame != null) {
				Destroy (frame);
			}	
		}

	}
}
