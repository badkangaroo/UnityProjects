using UnityEngine;
using System.Collections;

public class GO : MonoBehaviour
{
		public GameObject go;
		// Use this for initialization
		void Start ()
		{
				GameObject g = GameObject.Instantiate (go) as GameObject;
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
}
