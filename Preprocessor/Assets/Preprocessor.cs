//#define LOWHEALTH
using UnityEngine;
using System.Collections;

public class Preprocessor : MonoBehaviour {
	// Use this for initialization
	public int health = 10;
	void Start () {
#if UNITY_EDITOR && LOWHEALTH
			health = 1;
#elif UNITY_EDITOR
			health = 1000;
#endif
	}
}
