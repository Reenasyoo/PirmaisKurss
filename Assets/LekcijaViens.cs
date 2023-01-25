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
        //Method3(5); // method3 ( int param = 5)
        
         //Debug.Log(ReturnSum());

        // int returnedSum = ReturnSum();
        // Debug.Log(returnedSum);

        // int newSum = SumCalc2(1,2);
        // Debug.Log(returnedSum);

        // int newNewSum = newSum + 5;
        // Debug.Log(newNewSum);
        
        // uzd1();
        // uzd2("John");
        // uzd3(15, 16);
        // uzd3(5, 165);
        Method3(5);
        Method3(4,5);
        
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

    private void Method3(int param, int param2)
    {
        int c = param2 + param;
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

    private void uzd1()
    {
        Debug.Log("welcome Friends!");
        Debug.Log("Have a nice day!");
    }

    private void uzd2(string name)
    {
        Debug.Log("Welcome friend" + name);
        Debug.Log("Have a nice day!");
    }
    
    private void uzd3(int a, int b)
    {
        int c = a + b;
        print(c);
    }
}

/*
1. Write a program in C# Sharp to create a user define function.
---Expected Output :
Welcome Friends!
Have a nice day!

2. Write a program in C# Sharp to create a user 
define function with parameters
---Test Data : Please input a name : John
---Expected Output :
Welcome friend John !
Have a nice day!

3. Write a program in C# Sharp to create a function 
for the sum of two numbers.
--- Test Data : x : 15 y: 16
--- Expected Output : The sum of two numbers is : 31

*/

Raycast(Vector3 origin, Vector3 direction, out RaycastHit hitInfo, float maxDistance, int layerMask, QueryTriggerInteraction queryTriggerInteraction);
Raycast(Vector3 origin, Vector3 direction, float maxDistance = Mathf.Infinity, int layerMask = DefaultRaycastLayers, QueryTriggerInteraction queryTriggerInteraction = QueryTriggerInteraction.UseGlobal);