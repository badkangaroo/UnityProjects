using UnityEngine;
using System.Collections;
using System;
public class MultiDimensionalArray : MonoBehaviour {
	public GameObject[] oneDArray;
	public GameObject[,] mArray;
	// Use this for initialization
	void Start () {
		//GameObject[] oneDimension = new GameObject[5];
		GameObject[,] twoDimension = new GameObject[2,3];
		int width = twoDimension.GetLength(0);
		for( int i = 0; i < width; i++ ) {
			Debug.Log( i );
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
