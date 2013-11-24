using UnityEngine;
using System.Collections;

public class Second : MonoBehaviour
{
	int number = 0;
	void Awake()
	{
		for (int i = 0; i < 10000; i++)
		{
			number++;
		}
		Debug.Log("Second Awake: ");
	}
	
	void OnEnable()
	{
		Debug.Log("Second OnEnable");
	}
	
	void Start()
	{
		Debug.Log("Second Start");
	}
	
	void FixedUpdate()
	{
		Debug.Log("Second FixedUpdate");
	}
	void Update()
	{
		Debug.Log("Second Update");
	}
	
	void LateUpdate()
	{
		Debug.Log("Second LateUpdate");
		//Destroy(this);
	}
	
	void OnDisable()
	{
		Debug.Log("Second OnDisable");
	}
	
	void OnDestroy()
	{
		Debug.Log("Second OnDestroy");		
	}
}
