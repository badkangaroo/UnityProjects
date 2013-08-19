using UnityEngine;
using System.Collections;

public class ManageComponents : MonoBehaviour {
	public Component[] Parts;
	// Use this for initialization
	void Start () {
		float startTime = Time.time;
		
		Component[] list = GetComponents<Component>();
		
		foreach( Component c in list ) {
			Debug.Log( c.GetType() );
		}
 
	    float endTime = Time.time;
	    float timeElapsed = (endTime-startTime);
		Debug.Log( timeElapsed.ToString("F8") );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
