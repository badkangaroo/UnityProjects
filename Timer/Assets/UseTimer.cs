using UnityEngine;
using System.Collections;

public class UseTimer : MonoBehaviour {
	GameTimer timer;
	// Use this for initialization
	void Start () {
		timer = new GameTimer();
		timer.mTime = 3;
		timer.Tick+=OnTick;
		StartCoroutine( timer.Update( 0.1f ) );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTick(float t)
	{
		Debug.Log( "OnTick " + t );
	}
	
	void OnEnd()
	{
		timer.Tick-=OnTick;
		timer.End-=OnEnd;
		Debug.Log( " on end ended" );
	}
}
