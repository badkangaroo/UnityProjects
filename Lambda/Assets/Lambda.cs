using UnityEngine;
using System.Collections;
using System.Linq;
public class Lambda : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		int id = 0;
		GameObject g = new GameObject("A_" + id);
		for ( int i = 0; i < 3 ; i ++ ) {
			id++;
			GameObject b = new GameObject("B_" + id.ToString());
			b.transform.parent = g.transform;
			for( int j = 0; j < 5 ; j++ ) {
				id++;
				GameObject c = new GameObject("C_" + id.ToString());
				c.transform.parent = b.transform;
				for( int k = 0; k < 2 ; k++ ) {
					id++;
					GameObject d = new GameObject("D_" + id.ToString());
					d.transform.parent = c.transform;
				}
			}
		}
		
		ListHierarchy( g );
		
	}
	
	void ListHierarchy(GameObject go)
    {
		for ( int i = 0 ; i < go.transform.GetChildCount() ; i++ ) {
			GameObject g = go.transform.GetChild( i ).gameObject;
			Debug.Log( g.name );
			ListHierarchy( g );
		}
	}
	
	void CountDownRecrusion ( int i ) {
		if( i > 0 ) {
			i--;
			CountDownRecrusion( i );
		}
	}
	
	void CountUpRecurse( int i )
	{
		if ( i > 10 )
		{
			return;
		}
		
		i++;
		CountUpRecurse ( i );
	}

	
	
	// Update is called once per frame
	void Update () {
	
	}		
}
