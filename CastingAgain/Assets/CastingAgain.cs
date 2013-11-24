using UnityEngine;
using System.Collections;

public class CastingAgain : MonoBehaviour {
	enum simpleEnum : int{
		a,
		b,
		c
	}
	// Use this for initialization
	void Start () {
		simpleEnum MySimpleEnum = simpleEnum.b;
		int MyInt = (int)MySimpleEnum;
		Debug.Log( MyInt );
	}
	class Humanoid {
	}

	class Zombie : Humanoid {
	}

	class Person : Humanoid {
	}

	
}

struct a {
	static public explicit operator b(a A)
	{
		return new b();
	}
}
struct b {
	static public explicit operator a(b B)
	{
		return new a();
	}
}