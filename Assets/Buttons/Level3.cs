﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3 : MonoBehaviour {

    public float correctAnswers;
    public float wrongAnswers;
    ButtonClicker clicker;
    public bool clicked;
    // Use this for initialization
    void Start()
    {
        clicker = GetComponent<ButtonClicker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clicker.clickedTag == "apple" && clicked == false)
        {
            correctAnswers += 1;
            clicked = true;
        }
        if (clicker.clickedTag != "apple" && clicked == false)
        {
            wrongAnswers += 1;
            clicked = true;
        }
        if (correctAnswers == 3)
        {
            Debug.Log("You win!");
        }
    }
}

