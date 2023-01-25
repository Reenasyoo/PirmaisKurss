using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LekcijaTris : MonoBehaviour
{
    [SerializeField] private int option;
    [SerializeField] private string stringOption;
    [SerializeField] private Option enumOption;
    

    public enum Option
    {
        ONE,
        TWO,
        THREE,
    }

    void Start()
    {
        Method4(enumOption);
    }

    private void Method1(int choice)
    {
        switch (choice)
        {
            case 0 :
                Debug.Log("0");
                break;

            case 1 :
                Debug.Log("1");
                break;

            case 2 :
                Debug.Log("2");
                break;
            default :
                Debug.Log("Default");
                break;
        }
    }
    
    private void Method2(int choice)
    {
        switch (choice)
        {
            case 0 :
                Debug.Log("0");
                break;

            case 1 :
                Debug.Log("1");
                break;

            case 2 :
                Debug.Log("2");
                break;
        }
    }

    private void Method3(string choice)
    {
        switch (choice)
        {
            case "A" :
                Debug.Log("0");
                break;

            case "Name" :
                Debug.Log("1");
                break;

            case "2" :
                Debug.Log("2");
                break;
        }
    }

    private void Method4(Option choice)
    {
        switch (choice)
        {
            case Option.ONE :
                Debug.Log("0");
                break;

            case Option.TWO :
                Debug.Log("1");
                break;

            case Option.THREE :
                Debug.Log("2");
                break;
        }
    }

    private void Example()
    {
        int x = 0;
 
        switch (x)
        {
            case 10:
                Debug.Log("A+");
                break;
 
            case 9:
                Debug.Log("A");
                break;
 
            case 8:
            case 7:
                Debug.Log("B");
                break;
 
            case 6:
                Debug.Log("C");
                break;
 
            case 5:
                Debug.Log("E");
                break;
 
            default:
                Debug.Log("F");
                break;
        }
    }
}

/*
Create a C# program that calculates a student's grade from an integer. 
Ask the user for a number (x) and answer the following:

10 - A+
9 - A
7,8 - B
6 - C
5 - E
0,4 - F

*/