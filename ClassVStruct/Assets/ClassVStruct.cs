using UnityEngine;
using System.Collections;


public class ClassVStruct : MonoBehaviour {
	struct MyStruct {
		public int a;
	}

	class MyClass {
		public int a;
	}

	// Use this for initialization
	void Start () {
		MyClass mClass = new MyClass();
		MyStruct mStruct = new MyStruct();

		mClass.a = 1;
		mStruct.a = 1;

		MyStruct ms = mStruct;
		ms.a = 3;
		Debug.Log( ms.a + " and " + mStruct.a );
		
		MyClass mc = mClass;
		mc.a = 3;
		Debug.Log( mc.a + " and " + mClass.a );
		
		MyClass mc2 = new MyClass();
		mc2.a = mClass.a;
		mc2.a = 7;
		Debug.Log( mc.a + " and " + mClass.a + " and " + mc2.a );
	}
}