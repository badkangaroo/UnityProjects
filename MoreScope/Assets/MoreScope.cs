using UnityEngine;
using System.Collections;
public class MoreScope : MonoBehaviour
{
	
		OtherScope other;
	
		// Use this for initialization
		void Start ()
		{
				other = (OtherScope)GameObject.FindObjectOfType (typeof(OtherScope));
				Debug.Log (other.gameObject.name);
		}
	
		// Update is called once per frame
		public float otherScale;
		void Update ()
		{
				other.Size = otherScale;
		}
}
