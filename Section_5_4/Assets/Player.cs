using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public static Vector3 pos;
	// Use this for initialization
	void Start () {
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		bool WKey = Input.GetKey( KeyCode.W );
		bool SKey = Input.GetKey( KeyCode.S );
		bool AKey = Input.GetKey( KeyCode.A );
		bool DKey = Input.GetKey( KeyCode.D );
		if( WKey ) {
			pos.z += 0.1f;
		}
		if( SKey ) {
			pos.z -= 0.1f;
		}
		if( AKey ) {
			pos.x -= 0.1f;
		}
		if( DKey ) {
			pos.x += 0.1f;
		}
		gameObject.transform.position = pos;		
	}
}
