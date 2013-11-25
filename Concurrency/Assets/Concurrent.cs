using UnityEngine;
using System.Collections;

public class Concurrent : MonoBehaviour
{
	
	public bool StartCoroutines;
	
	public float NextTime;
	public float WaitTime = 3;
	
	public bool KeepRepeating = true;
	public bool RestartCoroutine = false;
	public float RepeatTime = 2.0f;
	public int next = -1;
	

	
	IEnumerator Gulp(int gulps)
	{
		int gulp = 0;
		while (gulp < gulps)
		{
			Debug.Log("Gulp...");
			yield return new WaitForSeconds(0.4f);
			++gulp;
		}
	}

	IEnumerator DayInTheLife(float t)
	{
		while (KeepRepeating)
		{
			int rand = Random.Range(0, 3);
			Debug.Log("I woke up, then...");
			yield return new WaitForSeconds(t);
			
			switch (rand)
			{
				case 0:
					Debug.Log("drank some coffee with...");
					yield return new WaitForSeconds(t);
					StartCoroutine("Gulp", 3);
					goto hadCoffee;
					break;
				case 1:
					Debug.Log("ate toast with...");
					yield return new WaitForSeconds(t);
					goto hadToast;
					break;
				case 2:
					Debug.Log("ate brains with...");
					yield return new WaitForSeconds(t);
					goto hadBrains;
					break;
			}
			
			hadCoffee:
			rand = Random.Range(0, 3);
			switch (rand)
			{
				case 0:
					Debug.Log("cream...");
					yield return new WaitForSeconds(t);
					break;
				case 1:
					Debug.Log("cream and sugar...");
					yield return new WaitForSeconds(t);
					break;
				case 2:
					Debug.Log("nothing in it...");
					yield return new WaitForSeconds(t);
					break;
			}
			
			Debug.Log("then i went to...");
			yield return new WaitForSeconds(t);
			goto goWork;
		
			hadToast:
			rand = Random.Range(0, 3);
			switch (rand)
			{
				case 0:
					Debug.Log("butter and jam...");
					yield return new WaitForSeconds(t);
					break;
				case 1:
					Debug.Log("butter...");
					yield return new WaitForSeconds(t);
					break;
				case 2:
					Debug.Log("nothing on it...");
					yield return new WaitForSeconds(t);
					break;
			}
			
			Debug.Log("then i went to...");
			yield return new WaitForSeconds(t);
			goto goWork;
		
			hadBrains:
			rand = Random.Range(0, 3);
			switch (rand)
			{
				case 0:
					Debug.Log("with ear and nose...");
					yield return new WaitForSeconds(t);
					break;
				case 1:
					Debug.Log("just an ear...");
					yield return new WaitForSeconds(t);
					break;
				case 2:
					Debug.Log("strawberries and banannas...");
					yield return new WaitForSeconds(t);
					break;
			}
			
			Debug.Log("then i went to...");
			yield return new WaitForSeconds(t);
			goto goWork;

			goWork:
			rand = Random.Range(0, 3);
			switch (rand)
			{
				case 0:
					Debug.Log("the office...");
					yield return new WaitForSeconds(t);
					break;
				case 1:
					Debug.Log("the gym...");
					yield return new WaitForSeconds(t);
					break;
				case 2:
					Debug.Log("the graveyard...");
					yield return new WaitForSeconds(t);
					break;
			}
			
			Debug.Log("and after went home to sleep...");
			yield return new WaitForSeconds(t);
		}
	}
	
	IEnumerator RepeatTimer(float t)
	{
		while (KeepRepeating)
		{
			int random = Random.Range(0, 3);
			
			Debug.Log("pick a an option: " + random);
			
			yield return new WaitForSeconds(t);
			
			switch (random)
			{
				case 0:
					Debug.Log("doing first option");
					yield return new WaitForSeconds(t);
					break;
				
				case 1:
					Debug.Log("doing second option");
					yield return new WaitForSeconds(t);
					break;
				
				case 2:
					Debug.Log("doing third option");
					yield return new WaitForSeconds(t);
					break;

				default:
					Debug.Log("doing some other option");
					yield return new WaitForSeconds(t);
					break;
			}
		}
	}
	
	public bool StopTheRoutine;	
	
	public GameObject[] lotsOfObjects;
	
	IEnumerator FillUpObjects()
	{
		lotsOfObjects = new GameObject[40000];
		for (int i = 0; i < 40000; i++)
		{
			GameObject g = GameObject.CreatePrimitive(PrimitiveType.Cube);
			g.name = i.ToString() + "_cube";
			float rx = Random.Range(-1000, 1000);
			float ry = Random.Range(-1000, 1000);
			float rz = Random.Range(-1000, 1000);
			g.transform.position = new Vector3(rx, ry, rz);
			g.transform.localScale = new Vector3(10, 10, 10);
			lotsOfObjects [i] = g;
			yield return null;
		}
	}
	
	IEnumerator MultiStep()
	{
		Debug.Log("First");
		yield return null;
		Debug.Log("Second");
		yield return null;
		Debug.Log("Third");
		yield return null;
		Debug.Log("Fourth");
		yield return null;
	}
	
	void Start()
	{
		StartCoroutine("DayInTheLife", 2);
	}
	
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			MultiStep();
		}
		
		if (StopTheRoutine)
		{
			StopCoroutine("DayInTheLife");
			StopTheRoutine = false;
		}
		
		if (RestartCoroutine)
		{
			KeepRepeating = true;
			StartCoroutine(RepeatTimer(RepeatTime));
			RestartCoroutine = false;
		}
		
		if (StartCoroutines)
		{
			for (int i = 0; i < 3; i++)
			{
				StartCoroutine_Auto(DelayStatement(i));
			}
			StartCoroutines = false;
		}
	}
	
	
	IEnumerator DelayStatement(int i)
	{
		Debug.Log(i + " ) Started at: " + Time.fixedTime);
		
		yield return new WaitForSeconds(3.0f);
		
		Debug.Log(i + " ) Ended at: " + Time.fixedTime);
	}
}
