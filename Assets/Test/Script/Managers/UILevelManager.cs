using UnityEngine;
using System.Collections;

public class UILevelManagerg : MonoBehaviour {



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

	public void GoToGameOverScene(){
		GameStateManagert.setGameState (GameStatet.GameOver);
		Application.LoadLevelAsync ("GameOverScene");

	}
}
