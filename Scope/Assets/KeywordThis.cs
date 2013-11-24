using UnityEngine;
using System.Collections;

public class KeywordThis : MonoBehaviour
{
		public class MyThis
		{
				float MyFloat;
		
				public void AssignMyFloat (float f)
				{
						MyFloat = f;
				}
		
				public void ShowMyFloat ()
				{
						Debug.Log (MyFloat);
				}
				public void AssignThisMyFloat (float MyFloat)
				{
						this.MyFloat = MyFloat; //ambibuous MyFloat
				}

		}
		class MyAwkwardClass
		{
				int MyBadlyNamedInt = 0;
				void PoorlyNamedFunction ()
				{
						Debug.Log (this.MyBadlyNamedInt);
						int MyBadlyNamedInt = 7;
						Debug.Log (this.MyBadlyNamedInt);
				}

		}

		// Use this for initialization
		void Start ()
		{
				MyThis mt = new MyThis ();
				mt.AssignMyFloat (3.0f);
				mt.ShowMyFloat ();	
		}
}

