using System;

class Program
{
    static void Main()
    {
        Patient p = new Patient();
        p.Examine("Jamison");

        Child c = new Child();
        c.Inoculate();
        c.Examine("Junior Jamison");
        
        Adult a = new Adult();

        a.Adultmessage();


        Console.ReadKey();
    }
}