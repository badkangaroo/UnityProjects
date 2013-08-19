using UnityEngine;
using System.Collections;
using System.Linq;

public class Linq : MonoBehaviour {
	
	public class Zombie {
		public int hitPoints;
		public Zombie() {
			this.hitPoints = Random.Range( 1, 100 );
		}
	}
	
	
	// Use this for initialization
	void Start () {
		int[] numbers = {0,1,2,3,4,5,6,7,8,9,10};
		var aThingHere = 9;
		var anotherThingThere = (object)9;
		var aDifferentThing = (float)9;

		var everyThird = from n in numbers where (n % 3) == 0 select n;
		foreach( int i in everyThird ) {
			Debug.Log( i );
		}
		
		Zombie[] zombies = new Zombie[100];
		for ( int i = 0; i < 100; i++ ) {
			zombies[i] = new Zombie();	
		}
		
		var weakZombies = from z in zombies where z.hitPoints < 50 select z;
		foreach( Zombie z in weakZombies ) {
			Debug.Log( z.hitPoints );
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
