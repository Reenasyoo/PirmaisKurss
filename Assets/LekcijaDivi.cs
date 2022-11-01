using UnityEngine;

public class LekcijaDivi : MonoBehaviour
{
    public int inputNumber = 0;
    private int guesableNumber = 0;
    
    void Start()
    {
        guesableNumber = Random.Range(0, 10);
    }

    private void Method1()
    {
        int a = 3;
        int b = 2;
        
        if (1 < 2)
        {
            Debug.Log("true");
        }
        
        if (a > b)
        {
            Debug.Log("true2");
        }
    }

    private void Method2()
    {
        int a = 2;
        int b = 1;

        if (a < b)
        {
            Debug.Log("if true");
        }
        else
        {
            Debug.Log("if not true");  
        }
    }

    private void Method3()
    {
        int a = 2;
        int b = 2;

        if (a < b)
        {
            Debug.Log("if true");
        }
        else if (a == b)
        {
            Debug.Log("Equal");
        }
        else
        {
            Debug.Log("if not true");  
        }
    }

    private void Method4()
    {
        bool canJump = false;

        if (canJump)
        {
            Debug.Log("we jumped");
        }
        else if(!canJump)
        {
            Debug.Log("we no jump");
        }
    }

    private void Method5()
    {
        bool canJump = false;
        bool inAir = true;


        if (canJump)
        {
            Debug.Log("we jumped");
        }
        else if (inAir)
        {
            Debug.Log("we fly");
        }
    }

    private void Method6()
    {
        bool canJump = true;
        bool inAir = false;
        
        if (canJump)
        {
            canJump = false;
            inAir = true;
            Debug.Log(canJump);
        }

        if (canJump)
        {
            Debug.Log("We jump");
        }
    }

    private void Method7()
    {
        bool canAttack = true;
        bool isAttacking = false;

        if (canAttack && !isAttacking)
        {
            Debug.Log("we can attack");
            canAttack = false;
            isAttacking = true;
        }
    }

    private void Method8()
    {
        bool canAttack = false;
        bool isAttacking = true;

        if (canAttack || !isAttacking)
        {
            Debug.Log("we can attack");
            canAttack = false;
            isAttacking = true;
        }
    }

    private void Method9(int age)
    {
        if (age < 18)
        {
            Debug.Log("under age");
        }
        else if (age > 70)
        {
            Debug.Log("too old");
        }
        else
        {
            Debug.Log("propper age");
        }
    }

    public void GuessingGame()
    {
        if (guesableNumber == inputNumber)
        {
            Debug.Log("you won");
            Debug.Log("number was : " + guesableNumber);
        }
        else
        {
            Debug.Log("Guess again");
            
            if (guesableNumber > inputNumber)
            {
                Debug.Log("Input number was too low");
            }
            else
            {
                Debug.Log("Input number was too high");
            }
        }
    }

    void uzd1(int x, int y)
    {
        
        if ( x % 2 == 0 && y % 2 == 0 || 
             x % 3 == 0 && y % 3 == 0 )
        {
            Debug.Log(x * y);
        }
        else
        {
            Debug.Log(x + y);
        }
    }
    
    void uzd2(int x, int y, int z)
    {
        if ( x * y > z || 
             x + y > z)
        {
            Debug.Log("true");
        }
        else
        {
            Debug.Log("false");
        }
    }
    
    void uzd3(int x)
    {
        if (x % 2 == 0)
        {
            Debug.Log("even");
        }
        else
        {
            Debug.Log("odd");
        }
    }
}

// > < >= <= == !=

/*
1. Divisible by 2 or 3
Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, 
otherwise returns their sum.
Expected input and output
DivisibleBy2Or3(15, 30) → 450
if (( x % 2) == 0) 
if(( x % 3) == 0 )


2. If greater than third one
Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers 
is greater than third one.
Expected input and output
IfGreaterThanThirdOne([2, 7, 12]) → true


3. If number is even
Given an integer, write a method that checks if it is even.
Expected input and output
IfNumberIsEven(721) → false

--- if(( x % 2 ) == 0)

*/