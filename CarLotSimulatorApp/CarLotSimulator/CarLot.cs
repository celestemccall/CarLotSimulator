using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot
{
    public List<Car> ParkingLot { get; set; } = new List<Car>();

    public void CheckCars()
    {
        foreach (var vehicle in ParkingLot)
        {
            System.Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
        }


    }
}

