using System.Collections.Generic;
using System;


namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public void CheckCars()
    {
        foreach (var vehicle in ParkingLot)
        {
            Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
        }


    }
}

