using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
		HasProperties hp = new HasProperties();
		hp.MyFloat = 5f;
		Debug.Log(hp.MyFloat);
		Debug.Log(hp.HalfFloat);
		hp.HalfFloat = 9f;
		Debug.Log(hp.MyFloat);
	}
	class HasProperties
	{
		protected float myFloat;
		public float MyFloat
		{
			get
			{
				return myFloat;
			}
			set
			{
				myFloat = value;
			}
		}
		public float HalfFloat
		{
			get
			{
				return this.myFloat / 2;
			}
			set
			{
				this.myFloat = value / 2;
			}
		}
	}
}