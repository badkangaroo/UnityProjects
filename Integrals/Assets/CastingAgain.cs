using UnityEngine;
using System.Collections;

public class CastingAgain : MonoBehaviour
{
	enum simpleEnum
	{
		a,
		b,
		c
	}
	// Use this for initialization
	void Start()
	{
		simpleEnum MySimpleEnum = simpleEnum.b;
		int MyInt = (int)MySimpleEnum;
		Debug.Log(MyInt);
	}
}