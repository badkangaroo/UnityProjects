using UnityEngine;
using System.Collections;

public class SimpleCallback : MonoBehaviour {
	
	public delegate void delegateCaller();
	
	public delegate void delegateWWW( WWW www );
	
	delegateCaller caller = FunctionToCall;

	void Start () {
		
		StartCoroutine( getWWW( "http://unity3d.com/robots.txt" , readText)  );
		StartCoroutine( getWWW( "http://upload.wikimedia.org/wikipedia/commons/thumb/e/ea/Clementine_albedo_simp750.jpg/800px-Clementine_albedo_simp750.jpg" , readTexture)  );
	}
	bool isDone;
	void Update()
	{
		if( isDone )
		{
			//do something
		}
	}
	public void readTexture( WWW www )
	{
		Texture2D texture = www.texture;
		gameObject.GetComponent<Renderer>().material.SetTexture( "_MainTex", texture );
	}
	
	public void readText( WWW www )
	{
		Debug.Log( www.text );
	}
	
	IEnumerator getWWW( string url, delegateWWW funcWWW)
	{
		WWW www = new WWW(url);
		yield return www;
		funcWWW( www );
	}
	
	static void FunctionToCall()
	{
		Debug.Log( "You called?" );
	}
	
	void StartingMessage()
	{
		Debug.Log( "im starting" );
	}
	
	void EndingMessage()
	{
		Debug.Log( "im done" );
	}
	
	IEnumerator StartEndTask(delegateCaller startFunc, float delay, delegateCaller endFunc)
	{
		startFunc();
		yield return new WaitForSeconds( delay );
		endFunc();
	}
	
	IEnumerator StartsATask()
	{
		Debug.Log( "starting" );
		yield return new WaitForSeconds(1);
		Debug.Log( "finishing" );
		caller();
	}

	public void PersonalCall()
	{
		Debug.Log ( "this is function" );
	}
	
	public void BusinessCall()
	{
		Debug.Log ( "Thank you for calling." );
	}
	
	IEnumerator StartsPerClassTask( SimpleCallback callThis )
	{
		Debug.Log( "starting" );
		yield return new WaitForSeconds(2);
		Debug.Log( "finishing" );

		//this is quite specific
		callThis.PersonalCall();
	}

}