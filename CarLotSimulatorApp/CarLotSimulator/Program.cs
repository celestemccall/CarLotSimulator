using System;
using System.Collections.Generic;
using System.Reflection;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Done - Create a seperate class file called Car 
            //Done - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable  
            //Done - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() 
            //Done - The methods should take one string parameter: the respective noise property 


            //Done - Now that the Car class is created we can instanciate 3 new cars
            //Done - Set the properties for each of the cars
            //Done - Call each of the methods for each car

            var lot = new CarLot();

            var myCar = new Car();
            myCar.Year = 2009;
            myCar.Make = "Infiniti";
            myCar.Model = "G37";
            myCar.EngineNoise = "quiet";
            myCar.HonkNoise = "loud";
            myCar.IsDriveable = "totally driveable";

            lot.Cars.Add(myCar);

            var wifeCar = new Car()
            {
                Year = 2007,
                Make = "Ford",
                Model = "Focus",
                EngineNoise = "quiet",
                HonkNoise = "loud",
                IsDriveable = "totally driveable"
            };

            lot.Cars.Add(wifeCar);

            var momCar = new Car( 2020, "Tesla","Model X","quiet","loud","totally driveable" );

            lot.Cars.Add(momCar);

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}" );
            }


        }
               
    }
}
            
             


            

            //*************BONUS*************//

            // Done - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Done - Create a CarLot class
            //Done - It should have at least one property: a List of cars
            //Done - Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //Done - At the end iterate through the list printing each of car's Year, Make, and Model to the console
        
    

