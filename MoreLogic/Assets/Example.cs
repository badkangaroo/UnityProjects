using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
    public PrimitiveType primitiveType;
    GameObject obj;
    public enum colorType
    {
        red,
        blue,
        green
    }
    public colorType myColor;

    // Use this for initialization
    void Start()
    {
        obj = GameObject.CreatePrimitive(primitiveType);
        if (myColor == colorType.red)
        {
            obj.GetComponent<Renderer>().material.color = Color.red;
        }
        if (myColor == colorType.blue)
        {
            obj.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (myColor == colorType.green)
        {
            obj.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void Update()
    {
		obj.GetComponent<Renderer>().material.color = Color.red;
    }
}
