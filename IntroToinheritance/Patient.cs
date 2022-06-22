using System;


public class Patient //First Class
{
    //properties

    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public  int age { get; set; }
    public int Weight { get; set; }
    public long SSN { get; set; }

    //Methods

    public void Examine(string pname)
    {
        Console.WriteLine("Examination of "+pname+"  completed");
    }

    public void Billing(long ssn)
    {
        Console.WriteLine("Billing completed....");
    }

}
public class Child : Patient // second Class
{
    public void Inoculate()
    {
        Console.WriteLine("Child has been inoculated..");
    }
}

public class Adult:Patient
{
    public void Adultmessage()
    {
        Console.WriteLine("This is an Adult class...");
    }
}

