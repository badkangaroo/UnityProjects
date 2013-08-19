using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class OutParam : MonoBehaviour {
	public GameObject[] GameObjectArray;
	// Use this for initialization
	void Start () {
		
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
	}
	
	GameObject[] sortObjects( GameObject[] objects )
	{
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
			}
		}
		
		return objects;
	}
	
	// Update is called once per frame
	void Update () {
		GameObjectArray = sortObjects( GameObjectArray );
		for( int i = 0; i < GameObjectArray.Length; i++ )
		{
			Vector3 PositionA = GameObjectArray[i].transform.position;
			Debug.DrawRay( PositionA, new Vector3( 0, i * 0.1f, 0 ), Color.red );
		}
	}
}
