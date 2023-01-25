using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LekcijaCetri : MonoBehaviour
{

    private int[] intArray = { 4, 6, 12, 432 };
    private List<int> intList = new List<int> { 4, 6, 12, 432 };
    
    void Start()
    {
        // Method8();
        uzd3();
    }

    public void Method1()
    {
        int loop = 0;

        while (loop < 5 )
        {
            Debug.Log("while " + loop);
            loop++;
        }
    }

    private void Method2()
    {
        int loop = 0;

        do
        {
            Debug.Log("do" + loop);
            loop++;
        } while (loop < 5);
    }

    private void Method3()
    {
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
    }

    private void Method4()
    {
        int i;
        for(i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
    }

    private void Method5()
    {
        int i;
        int lenght = 5;
        for(i = 0; i < lenght; i++)
        {
            Debug.Log(i);
        }
    }

    private void Method6()
    {
        int i;
        int lenght = 5;
        for(i = 0; i < lenght; i += 2)
        {
            Debug.Log(i);
        }
    }

    private void Method7()
    {
        for(int i = 5; i > 0; i--)
        {
            Debug.Log(i);
        }
    }

    private void Method8()
    {
        for(int i = 0; i < 5; i++)
        {
            if( i == 1 )
            {
                continue;
            }

            if( i == 3 )
            {
                break;
            }

            Debug.Log(i);
        }
    }

    private void Method9()
    {
        foreach( int value in intArray  )
        {
            Debug.Log(value);
        }
    }

    private void Method10()
    {
        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log( intArray[i] );
        }
    }

    private void Method11()
    {
        for (int i = 0; i < intList.Count; i++)
        {
            Debug.Log( intList[i]);
        }
    }

   private void uzd1()
   {
        int loop = 0;

        while(loop < 10)
        {
            loop +=2;
            Debug.Log(loop);
        }
   }

   private void uzd2()
   {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }
   }

   private void uzd3()
   {
        int sum = 0;
        for (int i = 0; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
   }

    
}

/*
1 . Print the numbers in the following format up to 10
Expected Output :
2 4 6 8 10

2. Write a program in C# Sharp to display the first 10 natural numbers. 
Expected Output :
1 2 3 4 5 6 7 8 9 10


3. Write a C# Sharp program to find the sum of first 10 natural numbers.
Expected Output :
The first 10 natural number is :
1 2 3 4 5 6 7 8 9 10
The Sum is : 55
*/