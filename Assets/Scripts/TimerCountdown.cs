using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCountdown : MonoBehaviour {

	public static TimerCountdown instance = null;
	public float timer;
	public float timeTotal;
	public bool timeIsUp =  false;
	public bool useTimer;
	// Use this for initialization

	void Awake()
	{ 
		if (useTimer == true){
			if (instance == null) {
				instance = this;
				DontDestroyOnLoad(gameObject);

			} 
			else if (instance != this) 
			{
					Destroy (gameObject);
			}
		}
	}

	void Start () 
	{
		timeTotal = timer;
	}


	void Update () 
	{
		if (useTimer == true) 
		{
			if (timer > 0) 
			{
				timer -= Time.deltaTime;
			}
			else {
				timeIsUp = true;
				}
		}
	}
}
