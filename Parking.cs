
//instantiating  Parking class 
using System;

Parking park = new Parking();

//
bool stopping = true;
do
{
    Console.WriteLine(" **** PARKING SYSTEM **** ");

    Console.WriteLine("please enter your option: ");
    Console.WriteLine(" 1 - Add a car");
    Console.WriteLine(" 2 - Remove a car");
    Console.WriteLine(" 3 - List cars");
    Console.WriteLine(" 4 - Finish");



    string optionSelected = Console.ReadLine();
    switch (optionSelected)
    {
        case "1":
            park.AddCar();

            break;
        case "2":
            park.RemoveCar();

            break;
        case "3":
            park.DisplayCars();

            break;
        case "4":
            Console.WriteLine("Finish program!");
            break;
    }

} while (stopping != false);