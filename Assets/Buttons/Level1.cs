using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : MonoBehaviour
{
    public float correctAnswers;
    public float wrongAnswers;
    ButtonClicker clicker;
    // Use this for initialization
    void Start()
    {
        clicker = GetComponent<ButtonClicker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (clicker.clickedTag == "apple")
        {
            correctAnswers += 1;
        }
        if (correctAnswers == 3)
        {
            Debug.Log("You win!");
        }
        if (wrongAnswers >= 1)
        {
            Debug.Log("You fucked up!");
        }
    }
}
