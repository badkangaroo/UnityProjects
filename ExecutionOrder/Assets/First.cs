using UnityEngine;
using System.Collections;

public class First : MonoBehaviour
{
	void Awake()
	{
		Debug.Log("First Awake");
	}
	
	void OnEnable()
	{
		Debug.Log("First OnEnable");
	}
	
	void Start()
	{
		Debug.Log("First Start");
	}
	
	void FixedUpdate()
	{
		Debug.Log("First FixedUpdate");
	}
	void Update()
	{
		Debug.Log("First Update");
	}
	
	void LateUpdate()
	{
		Debug.Log("First LateUpdate");
		//Destroy(this);
	}
	
	void OnDisable()
	{
		Debug.Log("First OnDisable");
	}
	
	void OnDestroy()
	{
		Debug.Log("First OnDestroy");		
	}
}
