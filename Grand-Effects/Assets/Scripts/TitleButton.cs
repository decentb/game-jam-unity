﻿using UnityEngine;
using System.Collections;

public class TitleButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnMouseDown()
    {
        Debug.Log("Start Game");
        Application.LoadLevel(Application.loadedLevel + 1);
    }

	// Update is called once per frame
	void Update () {
        
	}
}
