using UnityEngine;
using System.Collections;

public class SlowProcess : MonoBehaviour {
	float NextTime;
	public float DelayTime;
	public bool DoMove;
	public GameObject[] GameObjectArray;
	public float LastTime;
	// Use this for initialization
	void Start () {
		DelayTime = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		new WaitForSeconds( 5 );
		
		/*
        Debug.Log( Time.fixedTime - LastTime);
		if( Time.fixedTime > NextTime ) {
			ArrayList aList = new ArrayList();
			GameObject[] gameObjects = (GameObject[])GameObject.FindObjectsOfType( typeof(GameObject) );
	        foreach( GameObject go in gameObjects )
	        {
	            if( go.name == "Sphere" )
	            {
	                aList.Add( go );
	            }
	        }
		    GameObjectArray = aList.ToArray( typeof( GameObject ) ) as GameObject[];
			
			StartCoroutine( sortObjects( GameObjectArray) );
			
			
			//NextTime = Time.fixedTime + DelayTime;
			float rX = Random.Range(-1000, 1000) * 0.01f;
			float rY = Random.Range(-1000, 1000) * 0.01f;
			float rZ = Random.Range(-1000, 1000) * 0.01f;
			Vector3 RandomPosition = new Vector3(rX, rY, rZ);
			transform.localPosition = RandomPosition;
	    }
		LastTime = Time.fixedTime;
		*/
	}

	IEnumerator sortObjects( GameObject[] objects)
    {
		bool done;
		
		do{
			done = true;
	        for( int i = 0; i < objects.Length-1; i++ )
	        {
	            Vector3 PositionA = objects[i].transform.position;
	            Vector3 PositionB = objects[i+1].transform.position;
	 
	            Vector3 VectorToA = PositionA - transform.position;
	            Vector3 VectorToB = PositionB - transform.position;
	 
	            float DistanceToA = VectorToA.magnitude;
	            float DistanceToB = VectorToB.magnitude;
	 
	            if( DistanceToA > DistanceToB ) {
	                GameObject temp = objects[i];
	                objects[i] = objects[i+1];
	                objects[i+1] = temp;
					done = false;
	            }
	        }
		} while ( !done );
				
        yield return objects;
    }
}
