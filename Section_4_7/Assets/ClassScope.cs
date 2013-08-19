using UnityEngine;
using System.Collections;

public class ClassScope : MonoBehaviour
{
	int ClassInt;
	
		void Start ()
		{
			int StartInt;
		
				for( int i = 0; i < 10; i++ )
				{
			
					Debug.Log( i );
			
				}
		}
	
		void Update ()
		{
			int UpdateInt;
		
				for( int i = 0; i < 10; i++ )
				{
			
					Debug.Log( i );
			
				}		
		}
}
