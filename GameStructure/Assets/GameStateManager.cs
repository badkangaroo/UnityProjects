using UnityEngine;
using System.Collections;

public class GameStateManager : MonoBehaviour {
	
	public enum GameState {
		Loading,
		Loaded,
		Starting,
		Started,
		Menuing,
		Menu,
		Playing,
		Play,
		Pausing,
		Paused,
		GameEnding,
		GameEnded,
		Exiting,
		Exit
	};
	
	public static GameState gameState;
	
	IEnumerator StateManager() {
		bool play = false;
		
		do {
			
			if( GameStateManager.gameState != GameState.GameEnding ) {
				play = true;
			}
			
			yield return null;
		} while ( play );
	}
	
	// Use this for initialization
	void Start () {
		GameStateManager.gameState = GameState.Loading;
		StartCoroutine( "StateManager" );
	}
	
	public GameState NextGameState;
	void Update() {
		if( GameStateManager.gameState != NextGameState ) {
			Debug.Log( "Changing State" );
			GameStateManager.gameState = NextGameState;
		}
	}
}
