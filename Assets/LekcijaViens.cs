using UnityEngine;

// One line comment

/*
 Multi 
 line 
 comment
 */

public class LekcijaViens : MonoBehaviour
{
    // acces type / value type / name / value
    private int number = 0;
    private float comats = 0.1f;
    private string name = "dog";
    private bool yesOrNo = true;

    private Transform _transform;

    public int number1;
    public int number2 = 3;
    
    
    
    void Start()
    {
        // Method1();
        // Method2(); // method call
        Method3(5); // method3 ( int param = 5)
        
        Debug.Log(ReturnSum());

        int returnedSum = ReturnSum();
        Debug.Log(returnedSum);

        int newSum = SumCalc2(1,2);
        Debug.Log(returnedSum);

        int newNewSum = newSum + 5;
        Debug.Log(newNewSum);
    }

    // method declaration
    // access type / return type / name
    private void Method1()
    {
        Debug.Log("Hello world!");
        Debug.Log(number);
        Debug.Log(2141241);
        
        Debug.Log(number + " adjfgaejyfb " + comats + " " + ( 2 + 1 ));
    }

    private void Method2()
    {
        int a = 1;
        int b = -3;
        int d; // = 0

        int c = a + b;
        Debug.Log(c);
    }

    private void Method3(int param)
    {
        int a = 1;

        int c = a + param;
        Debug.Log(c);
    }

    private void SumCalc(int a, int b)
    {
        int c = a + b;
        print(c);
    }
    
    
    private int SumCalc2(int a, int b)
    {
        int c = a + b;
        print(c);
        return c;
    }

    public void CallSum()
    {
        SumCalc(number1, number2);
    }

    private int ReturnSum()
    {
        int a = 1;
        int b = -3;
        int d; // = 0

        int c = a + b;
        Debug.Log(c);

        return c;
    }
}
