using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
//		int MyVariable = 7;
//		print (MyVariable);
//		MyVariable = 13
//		print (MyVariable);
//		MyVariable = 3;
//		print (MyVariable);
//		MyVariable = 73;
//		print (MyVariable);


//		int MyVariable = 7;
//		print (MyVariable + MyVariable);//prints 14
//		print (7 + 7);//prints 14

//		int MyVariable = 7;
//		int MyOtherVariable = 3;
//		print (MyVariable * MyOtherVariable);//prints 21
//		print (MyVariable * 3);//prints 21

		int MyVariable = 7;
		int MyOtherVariable = 3;
		print (MyVariable * MyOtherVariable);
		MyVariable = MyOtherVariable; //what's happening here?
		print (MyVariable * MyOtherVariable);
	}
    // Update is called once per frame
    void Update ()
    {
        
    }
}
