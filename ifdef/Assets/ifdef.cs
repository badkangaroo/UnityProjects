using UnityEngine;
using System.Collections;

public class ifdef : MonoBehaviour {

	// Use this for initialization
	void Start () {
		#if UNITY_EDITOR
			Debug.Log( "editor" );
		#endif
		#if UNITY_STANDALONE_OSX
    		Debug.Log("Stand Alone OSX");
  		#endif
  		#if UNITY_STANDALONE_WIN
    		Debug.Log("Stand Alone Windows");
  		#endif
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
