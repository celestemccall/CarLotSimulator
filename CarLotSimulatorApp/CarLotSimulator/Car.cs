using System;
namespace CarLotSimulator
{
	public class Car
	{
        public Car()
        {
        }

        public Car(int year, string make, string model, bool isdriveable)
		{
			Year = year;
			Make = make;
            Model = model;
			IsDriveable = isdriveable;

		}

		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDriveable { get; set; }


		public void MakeEngineNoise(string engineNoise)
		{
			EngineNoise = engineNoise;
			Console.WriteLine($"{Make} {Model} has an engin noise that sounds like {EngineNoise}.");
		}

		public void MakeHonkNoise(string honknoise)
		{
			HonkNoise = honknoise;
			Console.WriteLine($"{Make} {Model} has a honk noise that sounds like {HonkNoise}.");
		}

		  

	}
}

