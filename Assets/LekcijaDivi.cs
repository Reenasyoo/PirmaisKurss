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
}

// > < >= <= == !=