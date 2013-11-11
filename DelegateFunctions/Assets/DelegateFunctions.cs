using UnityEngine;
using System.Collections;

public class DelegateFunctions : MonoBehaviour {

	delegate void Del();
	delegate int iDel();
	delegate int lamb(int i);
	// Use this for initialization
	void Start () {
		int a = 10;

		Del d = delegate()
		{
			Debug.Log("delegate calling");
		};
		d();
		
		d = delegate()
		{
			Debug.Log( "a/2 = " + a/2 );	
		};
		HandlesDel(d);
		
		iDel id = delegate() {
			return 12;
		};
		AdsiDel(id);
		
	}
	
	void HandlesDel(Del del)
	{
		del();
	}
	
	void AdsiDel(iDel id)
	{
		Debug.Log("adding iDels together: " + id()*2 );
	}
	// Update is called once per frame
	void Update () {
	
	}
}
