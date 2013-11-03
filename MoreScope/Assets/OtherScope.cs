using UnityEngine;
using System.Collections;

public class OtherScope : MonoBehaviour {
	
	public float Size;
	Vector3 mScale;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mScale = new Vector3( Size, Size, Size);
		gameObject.transform.localScale = mScale;
	}
}
