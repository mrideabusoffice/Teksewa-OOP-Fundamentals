/*Calculate bill amount for your Electricity Consumption
Ask user to supply electricity units consumed on his/her meter and calculate total amount based on following slabs:
 1 to 20 units = Rs 100
 21 to 25 units = Rs 5 per unit
 25 to 50 units = Rs 10 per unit
 Above 50 units Rs 2000 flat */

using System.Runtime.InteropServices.Marshalling;

// class ElectricityBill()
// {
    // static void Main()
    // {





        Console.Write("Enter the number of units consumed: ");
        double units = double.Parse(Console.ReadLine());

        double totalAmount = 0;

        switch(units)
        {
            case <=20:
            totalAmount = 100;
            break;

            case <=25:
            totalAmount = (units - 2) * 5.0f + 100;
            break;

            case  <=50:
            totalAmount = (units - 25) * 10 + 100 + (5 * 5);
            break;

            default:
            totalAmount = 2000;
            break;
        }

        Console.WriteLine($"Total Bill Amount is Rs. {totalAmount} only!");

        if (units >= 1 && units <= 20)
        {
            totalAmount = 100;
        }
        else if (units >= 21 && units <= 25)
        {
            totalAmount = (units - 20) * 5 + 100;
        }
        else if (units > 25 && units <= 50)
        {
            totalAmount = (units - 25) * 10 + 100 + (5 * 5);
        }
        else if (units > 50)
        {
            totalAmount = 2000;
        }
        else
        {
            Console.WriteLine("Invalid entry!");
        }
        Console.WriteLine($"Total Bill Amount is Rs. {totalAmount} only!");
    // }
// }


