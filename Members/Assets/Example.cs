using UnityEngine;
using System.Collections;

public class Members
{
	public void FirstFunction()
	{
		Debug.Log("First Function");
	}
}

public class Example : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Members m = new Members();
		m.FirstFunction();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
