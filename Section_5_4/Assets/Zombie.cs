using UnityEngine;
using System.Collections;

public class Zombie : MonoBehaviour {
	public static int numZombies;
	public bool die;
	public float speed = 0.01f;
	// Use this for initialization
	void Start () {
		numZombies++;
		Debug.Log( numZombies );
	}

	void Update() {
		Vector3 direction = ( Player.pos - transform.position ).normalized;
		float distance = ( Player.pos - transform.position ).magnitude;
		
		Vector3 move = transform.position + ( direction * speed );
		transform.position = move;

		if( distance < 1f ){
			die = true;
		}
		if( die ) {
			numZombies--;
			Destroy( gameObject );
		}
	}
	
	public static int CountZombies() {
		return numZombies;		
	}
}
