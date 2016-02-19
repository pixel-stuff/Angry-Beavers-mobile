using UnityEngine;
using System.Collections;

public class PlayerManagert : MonoBehaviour {

	#region Singleton
	public static PlayerManagert m_instance;
	void Awake(){
		if(m_instance == null){
			//If I am the first instance, make me the Singleton
			m_instance = this;
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
		GameStateManagert.onChangeStateEvent += handleChangeGameState;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void handleChangeGameState(GameStatet newState){
		Debug.Log ("PLAYER SEE THE NEW STATE : " + newState);
	}

	#region Intéraction
	public static void UP(){
		Debug.Log("UP ! ");
	}

	public static void DOWN(){
		Debug.Log("DOWN ! ");
	}

	public static void LEFT(){
		Debug.Log("LEFT ! ");
	}

	public static void RIGHT(){
		Debug.Log("RIGHT ! ");
	}
	#endregion Intéraction

	void OnDestroy(){
		GameStateManagert.onChangeStateEvent -= handleChangeGameState;
	}
}
