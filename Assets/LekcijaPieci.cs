using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LekcijaPieci : MonoBehaviour
{
    private Car car = new Car();
    private Volvo volvo = new Volvo("Volvo");
    public LekcijaCetri cetri;

    
    public Square rectangle = new Square();

    
    void Start()
    {
        // car.PrintName();

        // volvo.SetName("Volvo");
        // volvo.PrintName();

        // volvo.name = "adaegq";
        // volvo.protectedName = "asda";

        // volvo.SetSmth();
        // volvo.PrintName();

        // volvo.SetPrivateName("private volvo");
        // volvo.PrintPrivateName();

        // cetri.Method1();

        rectangle.PrintSize();
    }

}

public class Car
{
    public string name = "Car";
    private string privateName = "private car";
    protected string protectedName = "protected car";

    public virtual void PrintName()
    {
        UnityEngine.Debug.Log(name);
    }

    public void PrintPrivateName()
    {
        UnityEngine.Debug.Log(privateName);
    }

    public void SetName(string intputName)
    {
        name = intputName;
    }

    public void SetPrivateName(string intputName)
    {
        privateName = intputName;
    }
}

public class Volvo : Car
{
    // Constructor
    public Volvo(string constructorName)
    {
        SetName(constructorName);
        PrintName();
    }

    // // Destructor
    // ~Volvo()
    // {
        
    // }

    public void SetSmth()
    {
        Debug.Log(protectedName);
    }

    public override void PrintName()
    {
        UnityEngine.Debug.Log("Car name : " + name);
    }
}

public abstract class Shape
{
    public int size = 0;
    public virtual void PrintSize()
    {
        Debug.Log(size);
    }
}

public class Square : Shape
{
    public override void PrintSize()
    {
        Debug.Log("Size " + size);
    }
}