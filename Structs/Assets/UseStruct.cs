using UnityEngine;
using System.Collections;

public class UseStruct : MonoBehaviour
{
	BoxParameters ThatBox;
	// Use this for initialization
	void Start()
	{
	}
	
	// Update is called once per frame
	void Update()
	{
		ThatBox = GameObject.Find("Cube").GetComponent<Struct>().myParameters;
		gameObject.transform.position = new Vector3(0, ThatBox.height * 0.5f, -10);		
	}

}
