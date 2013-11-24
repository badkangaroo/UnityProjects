using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour
{
	public enum MonsterState
	{
		standing,
		wandering,
		chasing,
		attacking
	}
	public MonsterState mState;

	// Use this for initialization
	void Start()
	{
		int number = (int)mState;
		Debug.Log(number);
	}
	
	// Update is called once per frame
	void Update()
	{
		if (mState == MonsterState.standing)
		{
			print("standing monster is standing."); 
		}
		if (mState == MonsterState.wandering)
		{
			print("wandering monster is wandering."); 
		}
		if (mState == MonsterState.chasing)
		{
			print("chasing monster is chasing."); 
		}
		if (mState == MonsterState.attacking)
		{
			print("attacking monster is attacking."); 
		}
	}
}
