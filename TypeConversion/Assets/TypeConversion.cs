using UnityEngine;
using System.Collections;

public class TypeConversion : MonoBehaviour
{
	public float Zmove;

	// Update is called once per frame
	void Update()
	{
		float Zfloat = Zmove;
		transform.position = new Vector3(0, 0, Zfloat);
	}

}
