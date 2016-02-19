using UnityEngine;
using System.Collections;

public class InputManagert : MonoBehaviour {

	#region Singleton
	private static InputManagert m_instance;
	void Awake(){
		if(m_instance == null){
			//If I am the first instance, make me the Singleton
			m_instance = this;
			DontDestroyOnLoad(this.gameObject);
		}else{
			//If a Singleton already exists and you find
			//another reference in scene, destroy it!
			if(this != m_instance)
				Destroy(this.gameObject);
		}
	}
	#endregion Singleton

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		switch (GameStateManagert.getGameState ()) {
		case GameStatet.Menu:
			UpdateMenuState();
			break;
		case GameStatet.Playing:
			UpdatePlayingState();
			break;
		case GameStatet.Pause:
			UpdatePauseState();
			break;
		case GameStatet.GameOver:
			UpdateGameOverState();
			break;
		}
	}

	void UpdateMenuState(){
		if(Input.GetKeyDown(KeyCode.Return)){
			GameStateManagert.setGameState (GameStatet.Playing);
			Application.LoadLevelAsync ("LevelScene");
		}
	}

	void UpdatePlayingState(){
		if(Input.GetKeyDown("p")){
			Debug.Log("PAUSE ! ");
			GameStateManagert.setGameState(GameStatet.Pause);
		}

		if(Input.GetKeyDown("z") || Input.GetKeyDown("w")){
			PlayerManagert.UP();
		}
		
		if(Input.GetKeyDown("q") || Input.GetKeyDown("a")){
			PlayerManagert.LEFT();
		}
		
		if(Input.GetKeyDown("s")){
			PlayerManagert.DOWN ();
		}
		
		if(Input.GetKeyDown("d")){
			PlayerManagert.RIGHT();
		}
	}

	void UpdatePauseState(){
		if(Input.GetKeyDown("p")){
			Debug.Log("DÉPAUSE ! ");
			GameStateManagert.setGameState(GameStatet.Playing);
		}
	}

	void UpdateGameOverState(){

	}

}
