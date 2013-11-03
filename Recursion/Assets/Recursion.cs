using UnityEngine;
using System.Collections;

public class Recursion : MonoBehaviour {

	// Use this for initialization
	GameObject a;
	void Start () {
		a  = GameObject.CreatePrimitive(PrimitiveType.Sphere);
		int id = 0;
		a.name = "A_"+ id;
		for ( int i = 0; i < 3 ; i ++ ) {
			id++;
			GameObject b = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
			b.name = "B_"+id;
			a.transform.localEulerAngles = new Vector3( 0, (360/3) * i, 0 );
			b.transform.localPosition = new Vector3( 6.0f, 0, 0);
			b.transform.parent = a.transform;
			
			for( int j = 0; j < 5 ; j++ ) {
				id++;
				GameObject c = GameObject.CreatePrimitive(PrimitiveType.Capsule);
				c.name = "C_"+id;
				b.transform.localEulerAngles = new Vector3( 0, (360/5) * j, 0 );
				c.transform.localPosition = new Vector3( 2.0f, 0, 0);
				c.transform.parent = b.transform;
		
				for( int k = 0; k < 2 ; k++ ) {
					id++;
					GameObject d = GameObject.CreatePrimitive(PrimitiveType.Cube);
					d.name = "D_"+id;
					c.transform.localEulerAngles = new Vector3( 0, (360/2) * k, 0 );
					d.transform.localPosition = new Vector3( 1.0f, 0, 0);
					d.transform.parent = c.transform;
				}
			}
		}
		//ListHierarchy( a );
		ArrayList myList = GetList( a );
		foreach( GameObject g in myList) {
			Debug.Log( g.name );
		}
		Debug.Log( myList.Count );
	}
	
	void RotateHieararchy( GameObject go ) {
		go.transform.Rotate( new Vector3( 0, 0.5f, 0 ) );
		for ( int i = 0 ; i < go.transform.GetChildCount() ; i++ ) {
			GameObject g = go.transform.GetChild( i ).gameObject;
			RotateHieararchy( g );
		}
	}

	void ListHierarchy(GameObject go)
  	{
		Debug.Log( go.name );
		for ( int i = 0 ; i < go.transform.GetChildCount() ; i++ ) {
			GameObject g = go.transform.GetChild( i ).gameObject;
			ListHierarchy( g );
		}
	}
	
	public ArrayList GetList( GameObject go ){
		ArrayList list = new ArrayList();
		BuildList( go, list );
		return list;
	}
	
	void BuildList( GameObject go, ArrayList l ) {
		l.Add( go );
		for ( int i = 0; i < go.transform.GetChildCount(); i++ ) {
			GameObject g = go.transform.GetChild( i ).gameObject;
			BuildList( g, l );
		}
	}
	

	// Update is called once per frame
	void Update () {
		RotateHieararchy( a );	
	}
}
