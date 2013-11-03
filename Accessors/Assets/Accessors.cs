using UnityEngine;
using System.Collections;

public class Accessors : MonoBehaviour {
	
	class doodad {
		//internally stored int
		private int mNumber;
		
		//publically accessible interface for int
		public int MyNumber
		{
			get
			{
				return mNumber;
			}
			set
			{ 
				if ( value > 0 )
					mNumber = value;
				else
					mNumber = 0;
			}
		}
		
		//constructor
		public doodad()
		{
			MyNumber = 0;
		}
	}
	
	class GetSet
	{
		public delegate void MyIntHandler(int i);
		public event MyIntHandler MyIntEvent;

		private int myInt;
		public int MyInt
		{
			get{return myInt;}
			set
			{
				myInt = value;
				
				if( MyIntEvent != null )
				{
					MyIntEvent(myInt);
				}
			}
		}
		
		public int doubleInt
		{
			get { return myInt * 2; }
		}
	}
	class ff {
		public int i = 0;
	}
	void Start ()
	{
		GetSet gs = new GetSet();
		gs.MyIntEvent += IntChanged;
		gs.MyInt = 10;
		Debug.Log( gs.doubleInt );
ff f = new ff();
		f.i = 1;
switch( (int)f )
{
	case ff:
		//do things
		break;
}
	}

	void IntChanged(int i)
	{
		Debug.Log( "change! " + i );
	}
	bool DidSwap(ref int a,ref int b)
	{
		if( a > b )
		{
			int temp = a;
			a = b;
			b = temp;
			return false;
		}
		else 
		{
			return true;
		}
	}

	IEnumerator sort( int[] ar )
	{
		bool done = true;
		
		for( int i = 0; i < ar.Length-1; i++ )
		{
			done = DidSwap( ref ar[i], ref ar[i+1] );
		}

		if( !done ) {
			Debug.Log( "iterating" );
			sort ( ar );
		}
		yield return null;
	}
	
	public int[] array = new int[]{ 1,3,4,6,1,2,3,5,6,1,23,4,6,67,100 };
	

	void Update () {
		
	}
}
