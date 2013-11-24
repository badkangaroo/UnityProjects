using UnityEngine;
using System.Collections;

public class Debugging : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //int a = 0, b = 0;
        int a = 0;
        int b = 0;
        Debug.Log(a + b);
        int c = a;
        int d = b;
		
        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("this");
        list.Add(1.0);
        list.Add(1.0f);
        //lists van have anything in them!
        foreach (object i in list)
        {
            Debug.Log(i);
            int j = (int)i;
            Debug.Log(j);
            string s = i as string;
            Debug.Log(s);			
        }
        Monster m = new Monster(7);
        Debug.Log(m.MaxHitPoints);

    }
		
    // Update is called once per frame
    void Update()
    {
	
    }
}

public class Monster
{
    public readonly int MaxHitPoints = 10;
    public Monster(int hp)
    {
        this.MaxHitPoints = hp;
    }
}
