using UnityEngine;
using System.Collections;

public class SwitchStatements : MonoBehaviour {

	public enum MyCases
	{
		first,
		second,
		third,
		fourth,
		fifth,
		sixth,
		seventh
	}

	public MyCases cases;
	
	void Update ()
	{
		


		switch( cases )
		{
		case MyCases.first:
			Debug.Log( "first case" );
			break;
		case MyCases.second:
			Debug.Log( "second case" );
			break;
		case MyCases.third:
			Debug.Log( "third case" );
			break;
		case MyCases.fourth:
			Debug.Log( "fourth case" );
			break;
		case MyCases.fifth:
			Debug.Log( "fifth case" );
			break;
		case MyCases.sixth:
			Debug.Log( "sixth case" );
			break;
		case MyCases.seventh:
			Debug.Log( "seventh case" );
			break;
		default:
			Debug.Log( "other case" );
			break;
		}
	}
}
