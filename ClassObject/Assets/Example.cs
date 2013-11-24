using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Vector3 vector = new Vector3(1, 2, 3);
        vector.x = 1.0f;
        transform.position = vector;
        int i = new int();
        Debug.Log(i);
    }
	
    // Update is called once per frame
    void Update()
    {

    }
}
