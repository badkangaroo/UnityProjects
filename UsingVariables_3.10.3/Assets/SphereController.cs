using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {
	public float Control;
	public float OtherControl;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = new Vector3 (Control, Control + Control, Control * Control);

		//transform.position = new Vector3 (
		//Mathf.Sin (Control) * OtherControl,
		//Mathf.Cos (Control) * OtherControl,
		//Control * OtherControl);
		float x = Mathf.Sin (Control) * OtherControl;
		float y = Mathf.Cos (Control) * OtherControl;
		float z = Control * OtherControl;
		transform.position = new Vector3 (x, y, z);
	}
}
