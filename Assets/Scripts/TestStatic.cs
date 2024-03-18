using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            MyClass m = new MyClass(i.ToString());
        }
        print(MyClass.num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class MyClass
    {
        public static int num = 0;

        public string name;

        public MyClass(string name0)
        {
            this.name = name;
            num++;
        }
    }
}
