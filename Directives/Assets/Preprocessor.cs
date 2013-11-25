//#define TESTING
using UnityEngine;
using System.Collections;

public class Preprocessor : MonoBehaviour
{
	// Use this for initialization
	
	void Start()
	{
		#if TESTING
		Debug.Log("just testing");
		#endif
		Debug.Log("normal behavior");
	}
	
	// Update is called once per frame
	void Update()
	{
		
	}
}
