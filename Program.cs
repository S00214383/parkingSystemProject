using System;
public class Parking
{



    List<string> vehicles = new List<string>();




    //declaring methods
    public void AddCar()
    {
        Console.WriteLine("Enter reg number to Add car: ");
        string regNumber = Console.ReadLine();

        vehicles.Add(regNumber);
        Console.WriteLine($"car {regNumber} added to the system !");


    }

    public void RemoveCar()
    {
        decimal initialPrice, priceByHour, totalHoursParked;
        string car;

        Console.WriteLine("Enter reg number to remove car: ");
        string regNumber = Console.ReadLine();

        Console.WriteLine("Enter initial price: ");
        initialPrice = Convert.ToDecimal(Console.ReadLine());


        Console.WriteLine("Enter price by Hour: ");
        priceByHour = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Enter total hours parked: ");
        totalHoursParked = Convert.ToDecimal(Console.ReadLine());

        //logic to calculate prices

        //does the math to pay
        decimal finalPrice = initialPrice + (priceByHour * totalHoursParked);




        //removes car from List
        vehicles.Remove(regNumber);
        Console.WriteLine($"Car {regNumber} removed from the system");

        //display the final price to customer
        Console.WriteLine($"Final price: {finalPrice} $");
    }

    public void DisplayCars()
    {
        Console.WriteLine("Displaying all registered cars: ");


        //display car list
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"car reg {vehicle} registered into the system");
        }
    }



}