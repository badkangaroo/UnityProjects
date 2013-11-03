using UnityEngine;
using System.Collections;

public class Abstraction : MonoBehaviour {
	
	abstract class BaseClass
	{
		public int Counter;
		public abstract void ImportantFunction();
	}
	
	abstract class SecondaryClass : BaseClass
	{
		public int Limit;
		public abstract bool AtLimit();
		public abstract void SetLimit(int l);
	}
	
	sealed class ChildClass : SecondaryClass
	{		
		public override void ImportantFunction()
		{
			Counter++;
			Debug.Log( Counter );
		}
		
		public override bool AtLimit()
		{
			return Counter >= Limit;
		}
		
		public override void SetLimit( int l )
		{
			Limit=l;
		}
	}
	
	class SiblingClass : BaseClass
	{
		public override void ImportantFunction()
		{
			Counter--;
			Debug.Log( Counter );
		}
	}
	
	public CountdownTimer countdown;
	void Start() {
		//BaseClass b = new BaseClass();
		
		ChildClass c = new ChildClass();
		c.ImportantFunction();
		c.ImportantFunction();
		c.ImportantFunction();
		c.ImportantFunction();
		
		SiblingClass s = new SiblingClass();
		s.ImportantFunction();
		s.ImportantFunction();
		s.ImportantFunction();
		s.ImportantFunction();
		
		countdown = new CountdownTimer();
		countdown.SetTime( 3.0f );
		countdown.BeginTimer();
	}
	void Update() {
		Debug.Log( countdown.normalizedTime );
		if( countdown.Ended() ) {
			countdown.BeginTimer();
		}
	}
}
