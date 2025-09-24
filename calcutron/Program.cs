using System.Xml.Serialization;

Calculatorapp(); 

void Calculatorapp()
{
    int firstnumber = 0;
    int secondnumber = 0;
    int result = 0;
    int choice = 0; 
    Console.WriteLine("Type in first number ");
     firstnumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("type second number");
     secondnumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an option");
    Console.WriteLine("1  - add");
    Console.WriteLine("2 - subtract");
    Console.WriteLine("3 - divide");
    Console.WriteLine("4 - mult");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {

        result = firstnumber + secondnumber;
        Console.WriteLine($"adding {firstnumber} and {secondnumber} equals {result}");
    }
    if (choice == 2)
    {
        result = firstnumber - secondnumber;
        Console.WriteLine($"subtracting {firstnumber} and {secondnumber} equals {result} ");
    }
    if (choice == 3)
    {
        result = firstnumber / secondnumber;
        Console.WriteLine($"dividing {firstnumber} by {secondnumber} equals {result}");
    }
    if (choice == 4)
    {
        result = firstnumber * secondnumber;
        Console.WriteLine($"multplying {firstnumber}by  {secondnumber} equals {result}");
    }
    else
    {
        Console.WriteLine("you did not enter right number");
    }
}