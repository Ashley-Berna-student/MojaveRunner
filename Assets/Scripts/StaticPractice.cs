using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(MyMath.Add(10, 15));
        print(MyMath.Add(13, 22));
        print(MyMath.Add(56, 83));
        print(MyMath.sumTotal);

        print(MyMath.Subtract(10, 5));

        print(MyMath.Multiply(4, 8));

        print(MyMath.Divide(10, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class MyMath
{
    public static int sumTotal = 0;
    public static int Add(int a, int b)
    {
        int result = a + b;
        sumTotal++;
        return result;
    }

    public static int Subtract(int a, int b)
    {
        int result = a - b;
        return result;
    }

    public static int Multiply(int a, int b)
    {
        int result = a * b;
        return result;
    }

    public static int Divide(int a, int b)
    {
        int result = a / b;
        return result;
    }
}
