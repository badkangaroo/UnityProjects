using UnityEngine;
using System.Collections;

public class BitwiseOperators : MonoBehaviour
{

	public enum characterClass
	{
		farmer = 0 << 0,
		fighter= 1 << 0,
		theif  = 1 << 1,
		wizard = 1 << 2,
		archer = 1 << 3,
		monk   = 1 << 4
	}

	// Use this for initialization
	void Start()
	{
		/*characterClass classA = characterClass.fighter;
		characterClass classB = characterClass.wizard;
		characterClass classC = characterClass.theif;
		characterClass multiclass = classA | classB | classC;
		characterClass f = multiclass & characterClass.fighter;
		characterClass w = multiclass & characterClass.wizard;
		characterClass t = multiclass & characterClass.theif;
		bool isFighter = f == characterClass.fighter;
		bool isWizard  = w == characterClass.wizard;
		bool isTheif   = t == characterClass.theif;
		characterClass newbie = characterClass.farmer;
		newbie = addClass( newbie, characterClass.wizard );
		newbie = addClass( newbie, characterClass.archer );
		newbie = removeClass( newbie, characterClass.archer);
		newbie |= characterClass.monk;
		Debug.Log("newbie: " + newbie); //0011
		Debug.Log( "fighter? " + isFighter + " wizard? " + isWizard + " theif? " + isTheif);

		Debug.Log( 0>>0 );
		Debug.Log( 1<<1 );
		Debug.Log( 1<<2 );
		Debug.Log( 1<<3 );
		Debug.Log( 1<<4 );
		Debug.Log( 1<<5 );
		int number = 758;
		bool even = (number & 1) == 0 ? true : false;
		Debug.Log( even );
		int n = 0xff;
		int p = ~n+1;
		Debug.Log("before: " + n + " after: " + p );*/
		//int a = 7;
		//int b = 3;
//		Debug.Log( BitwiseSub( a, b) );


		/*	Debug.Log( " a=" + bs(a) );
			Debug.Log( " b=" + bs(b) );
		int c = a & b;
			Debug.Log( " c=" + bs(c) );
		int r = a ^ b;
			Debug.Log( " r=" + bs(r) );
		while(c != 0)
		{
			Debug.Log( " s = c << 1" );
			Debug.Log( "   " + bs(c) );
			int s = c << 1;
			Debug.Log( " =s" + bs(s) );

			Debug.Log( " c = r & s" );
			Debug.Log("  r" + bs( r ) );
			Debug.Log(" &s" + bs( s ) );
			c = r & s;
			Debug.Log(" =c" + bs( c ) );

			Debug.Log( " r = r ^ s" );
			Debug.Log("  r" + bs( r ) );
			Debug.Log(" ^s" + bs( s ) );
			r = r ^ s;
			Debug.Log("  r" + bs( r ) );
		}*/
		Debug.Log((-123 & (1 << 31)) != 0);
		int? x = null;

	}


	int BitwiseDiv(int a, int b)
	{
		int divideStart = a;
		int timesDivided = 1;
		while (true)
		{
			divideStart = BitwiseSub(divideStart, b);
			if (divideStart <= 0)
				break;
			timesDivided = BitwiseAdd(timesDivided, 1);
		}

		return timesDivided;
	}
	
	int BitwiseMul(int a, int b)
	{
		int r = 0;
		while (b != 0)
		{
			if ((b & 1) != 0)
			{
				r = BitwiseAdd(r, a);
			}

			a = a << 1;

			if (b == 0)
			{
				r = a;
				break;
			}

			b = b >> 1;
		}

		return r;
	}

	string bitsToString(int number, int digits)
	{
		char[] binary = new char[digits];
		int digit = digits - 1;
		int place = 0;
		while (place < digits)
		{
			int d = number & (1 << place); 
			if (d != 0)
			{
				binary [digit] = '1';
			} else
			{
				binary [digit] = '0';
			}
			digit--;
			place++;
		}
		return new string(binary);
	}

	int BitwiseSub(int a, int b)
	{
		b = BitwiseAdd(~b, 1);
		return BitwiseAdd(a, b);
	}

	int BitwiseAdd(int a, int b)
	{
		int c = a & b;
		int r = a ^ b;
		while (c != 0)
		{
			int s = c << 1;	//shift digits to add
			c = r & s;		//find overlapping digits
			r = r ^ s;		//merge digits that don't overlap
		}
		return r;
	}

	public characterClass addClass(characterClass a, characterClass b)
	{
		return a | b;
	}

	public characterClass removeClass(characterClass a, characterClass b)
	{
		return a ^ b;
	}

	public bool containsClass(characterClass a, characterClass b)
	{
		return (a & b) == b;
	}

	// Update is called once per frame
	void Update()
	{

	}

}