﻿using UnityEngine;
using System.Collections;
using System;

public class IntroScriptt : MonoBehaviour {

	public Action onKeyDown;
	
	//public bool isPush = false;
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.Return) || f (Input.touchCount == 1) /* && !isPush*/) {
			//isPush = true;
			if(onKeyDown != null){
				Debug.Log ("INTRO ");
				onKeyDown();
			}
		}
	}
}
