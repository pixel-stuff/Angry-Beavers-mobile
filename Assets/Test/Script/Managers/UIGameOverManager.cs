using UnityEngine;
using System.Collections;

public class UIGameOverManagert : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ReturnToSceneMenu(){
		GameStateManagert.setGameState (GameStatet.Menu);
		Application.LoadLevelAsync ("MenuScene");
	}
	
	public void ReturnToLevelScene(){
		GameStateManagert.setGameState (GameStatet.Playing);
		Application.LoadLevelAsync ("LevelScene");
		
	}
}
