using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicker : MonoBehaviour
{
    Collider2D collidedWith;
    public string clickedTag;
    Level1 level1;
    Level2 level2;
    Level3 level3;
    Level4 level4;
    public GameObject clickedObject;
    // Use this for initialization
    public void Start()
    {
        collidedWith = GetComponent<Collider2D>();
        level1 = GetComponent<Level1>();
        level2 = GetComponent<Level2>();
        level3 = GetComponent<Level3>();
        level4 = GetComponent<Level4>();
        clickedObject = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        clickedTag = this.tag;
        clickedObject = this.gameObject;
        Debug.Log("I got clicked! Tag of this is:" + clickedTag);
        Debug.Log("My name is:" + clickedObject);
        level1.clicked = false;
        level2.clicked = false;
        level3.clicked = false;
        level4.clicked = false;
    }
}
