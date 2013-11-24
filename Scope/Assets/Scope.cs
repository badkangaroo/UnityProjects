using UnityEngine;
using System.Collections;

public class Scope : MonoBehaviour
{
		int MyInt = 1;

		void Start ()
		{
				for (int i = 0; i < 10; i ++) {
						print (i);
				}
				// i only exists between the { and }
				Debug.Log (this.MyInt); //class scope version of MyInt
				int MyInt = 3;
				Debug.Log (MyInt);
		}
}
