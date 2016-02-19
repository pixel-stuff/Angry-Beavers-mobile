using UnityEngine;
using System.Collections;
using System;

public class IntroScriptt : MonoBehaviour {

	public Action onKeyDown;
	
	//public bool isPush = false;
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey(KeyCode.Return) || (Input.touchCount == 1) /* && !isPush*/) {
			//isPush = true;
			if(onKeyDown != null){
				Debug.Log ("INTRO ");
				onKeyDown();
			}

		}
		if (Input.touchCount == 1) {    
			// touch on screen
			if (Input.GetTouch (0).phase == TouchPhase.Began) {
				if(onKeyDown != null){
					Debug.Log ("INTRO ");
					onKeyDown();
				}
			}
		}
}
}