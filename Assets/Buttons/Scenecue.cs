using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenecue : MonoBehaviour {
    Level1 lv1;
    Level2 lv2;
    Level3 lv3;
    Level4 lv4;
    ButtonClicker clicker;
    // Use this for initialization
    void Start () {
        lv1 = GetComponent<Level1>();
        lv2 = GetComponent<Level2>();
        lv3 = GetComponent<Level3>();
        lv4 = GetComponent<Level4>();
        clicker = GetComponent<ButtonClicker>();
    }
	
	// Update is called once per frame
	void Update () {
		if (lv1.correctAnswers == 3)
        {
            SceneManager.LoadScene("Level 2");
        }
        if (lv2.correctAnswers == 3)
        {
            SceneManager.LoadScene("Level 3");
        }
        if (lv3.correctAnswers == 3)
        {
            SceneManager.LoadScene("Level 4");
        }
	}
}
