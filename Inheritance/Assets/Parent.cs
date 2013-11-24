using UnityEngine;
using System.Collections;

public class Parent : MonoBehaviour
{
	public int SomeInt;
	// Use this for initialization
	void Start()
	{
		//ChildAbility();
	}
	
	// Update is called once per frame
	void Update()
	{
	
	}

	public void ParentAbility()
	{
		Debug.Log("inheritable function");
	}
}
