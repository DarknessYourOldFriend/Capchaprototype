using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public static Timer instance = null;
	Image timerImage;
	public float timer;
	float timeTotal;
	public bool timeIsUp =  false;
	public GameObject timerVisual;


	void Awake()
	{
		Debug.Log ("HELLO!");
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad(gameObject);

		} else if (instance != this) {
			Destroy (gameObject);
		}
	}


	void Start () 
	{
		timerImage = this.GetComponent<Image>();
		timeTotal = timer;
	}
	

	void Update () 
	{
		timer -= Time.deltaTime;
		timerImage.fillAmount = timer / timeTotal;
		if (timer <= 0) {
			timeIsUp = true;
		}
	}


}
