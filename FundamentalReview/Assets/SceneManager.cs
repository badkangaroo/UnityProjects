using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {
	public GameObject Sphere;
	public GameObject Target;
	private Camera MainCamera;
	public int SphereCount;
	public float Repel;
	public float Attract;
	private GameObject[] Spheres;
	
	// Use this for initialization
	void Start () {
		
		MainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
		
		Spheres = new GameObject[SphereCount];
		
		for( int i = 0; i < SphereCount; i++)
		{
			GameObject go = GameObject.Instantiate(Sphere) as GameObject;
			float rx = Random.Range(-10f, 10f);
			float ry = Random.Range(-10f, 10f);
			go.transform.position = new Vector3(rx, ry, 0f);
			Spheres[i] = go;			
		}
	}
	
	private Vector3 PushAway(GameObject source, GameObject target)
	{
		return (target.transform.position - source.transform.position).normalized;
	}
	
	private Vector3 PushToward(GameObject source, GameObject target)
	{
		return (source.transform.position - target.transform.position).normalized;
	}
	
	private float Distance( GameObject source, GameObject target )
	{
		return (target.transform.position - source.transform.position).magnitude;
	}
	
	// Update is called once per frame
	void Update () {
		//UpdateAttractor();
		foreach( GameObject me in Spheres)
		{
			foreach( GameObject other in Spheres )
			{
				if( other != me )
				{
					float d = Distance(me, other);
					float a = Distance(me, Target);
					
					Vector3 repelForce = PushAway(other, me) * (Repel / d );
					Vector3 attractForce = PushToward(Target, me) * (Attract / a);
					
					me.transform.position += repelForce + attractForce;
				}
			}
		}
	}
}
