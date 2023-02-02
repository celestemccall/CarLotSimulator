using System;
namespace CarLotSimulator
{
	public class Car
	{
		public Car()
		{
		}

		public Car(int year, string make, string model, string enginenoise, string honknoise, string isdriveable)
		{
			Year = year;
			Make = make;
			Model = model;
			EngineNoise = enginenoise;
			HonkNoise = honknoise;
			IsDriveable = isdriveable;

		}

		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public string IsDriveable { get; set; }

		public void MakeEngineNoise(string engineNoise)
		{
			Console.WriteLine(engineNoise);
		}

		public void MakeHonkNoise(string honknoise)
		{
			Console.WriteLine(honknoise);
		}


	}
}

