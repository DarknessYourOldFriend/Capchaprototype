using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicker : MonoBehaviour
{
    Collider2D clickedObject;
    public string clickedTag;
    Level1 level1;
    // Use this for initialization
    void Start()
    {
        clickedObject = GetComponent<Collider2D>();
        level1 = GetComponent<Level1>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        Debug.Log("I got clicked! Tag of this is:" + clickedTag);
        clickedTag = (clickedObject.tag);
        level1.clicked = false; 
    }
}
