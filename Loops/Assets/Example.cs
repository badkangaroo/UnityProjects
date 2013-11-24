using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{

    //public int counter = 0;
    public int numCubes = 10;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < numCubes; i++)
        {
            for (int j = 0; j < numCubes; j++)
            {
                GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                box.transform.position = new Vector3(i * 2.0f, j * 2.0f, 0f);
            }
        }
        Debug.Log("at the start");
        for (;;)
        {
            Debug.Log("before the return");
            break; //not return!
            Debug.Log("after the return");
        }
        Debug.Log("at the bottom");

    }
    // Update is called once per frame
    void Update()
    {   
        int counter = 0;
        while (true)
        {
            counter++;
            if (counter > 10)
            {
                break;
            }
        }
    }
}
