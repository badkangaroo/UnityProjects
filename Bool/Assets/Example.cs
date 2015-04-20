using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
		public int Gold;
		public bool SomeBool;
		// Use this for initialization
		void Start ()
		{
				SomeBool = (1 == 1);	
				int a = 1;
				int b = 3;
				SomeBool = (a == b);
				if (SomeBool) {
						transform.Rotate (new Vector3 (45f, 0f, 0f));
				}
		}
		public int change;
		// Update is called once per frame
		public GameObject A_Cube;
		public GameObject B_Cube;
		void Update ()
		{
				/*if (change >= 10) {
						transform.position = new Vector3 (3f, 0f, 0f);
				} else if (change <= -10) {
						transform.position = new Vector3 (-3f, 0f, 0f);
				} else {
						transform.position = new Vector3 (0f, 0f, 0f);
				}*/
				
				Color col = Color.red;
				float Ax = A_Cube.transform.position.x;
				float Ay = A_Cube.transform.position.y;
				float Bx = B_Cube.transform.position.x;
				float By = B_Cube.transform.position.y;
				if (Ax > Bx) {
						col = Color.black;
				} else if (Ax <= Bx) {
						col = Color.blue;
				}
				GetComponent<Renderer>().material.color = col;

		}
}
