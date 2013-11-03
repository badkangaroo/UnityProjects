using UnityEngine;
using System.Collections;
using System.Threading;

public class MySingleton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Singleton s = Singleton.Instance;
		s.Sing();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public sealed class Singleton
	{
	    private static Singleton instance = null;
	    private static readonly object padlock = new object();
	
	    Singleton()
	    {
	    }
		
		public void Sing(){
			Debug.Log( "la la la la la!" );
		}
	
	    public static Singleton Instance
	    {
	        get
	        {
	            lock (padlock)
	            {
	                if (instance == null)
	                {
	                    instance = new Singleton();
	                }
	                return instance;
	            }
	        }
	    }
	}
}
