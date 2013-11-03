using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Dictionaries : MonoBehaviour
{
	public Dictionary<string,int> MyDictionary;
	public string[] objectNames;
	public int[] objectCounts;
	
	public GameObject[] ObjectStack;
	// Use this for initialization
	void Start ()
	{
		GameObject[] gos = GameObject.FindObjectsOfType( typeof( GameObject ) ) as GameObject[];
		#region Dictionary
		MyDictionary = new Dictionary<string,int>();
		MyDictionary.Add("Zombies",10);
		//prints 10;
		Debug.Log ( MyDictionary["Zombies"] );
		
		//int and object
		Dictionary<int, Object> obs = new Dictionary<int, Object>();
		Object[] allObjects = GameObject.FindObjectsOfType( typeof( Object ) ) as Object[];

		for( int i = 0; i < allObjects.Length; i++ ) {
			obs.Add( i, allObjects[i] );
			Debug.Log( obs[i] );
		}
		
		//lists GameObject names in the scene
		Dictionary<string, int> SceneDictionary = new Dictionary<string, int>();
		foreach( GameObject go in gos )
		{
			
			bool containsKey = SceneDictionary.ContainsKey(go.name);
			if( containsKey )
			{
				SceneDictionary[go.name] += 1;
			}
			else
			{
				SceneDictionary.Add(go.name, 1);
			}
		}
		objectNames = new string[SceneDictionary.Keys.Count];
		objectCounts = new int[SceneDictionary.Values.Count];
		SceneDictionary.Keys.CopyTo(objectNames, 0);
		SceneDictionary.Values.CopyTo(objectCounts, 0);
		SceneDictionary.Remove("Main Camera");
		#endregion
		
		#region Stack
		//create a new stack
		Stack objectStack = new Stack();
		//assign objects to the stack using push
		foreach( GameObject go in gos )
		{
			objectStack.Push( go );
		}
		//initialize the class scope ObjectStack to view in the inspector panel
		ObjectStack = new GameObject[objectStack.Count];
		//copy the stack to the array in Unity
		objectStack.CopyTo(ObjectStack, 0 );
		#endregion
	}
}
