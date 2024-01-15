namespace Patterns.AbstractFactory
{
	interface ICar
	{
		string Name { get; }
	}

	class Sedan : ICar
	{
		public string Name => "Sedan";
	}

	class SUV : ICar
	{
		public string Name => "SUV";
	}

	interface ICarFactory
	{
		ICar CreateCar();
	}

	class SedanFacory : ICarFactory
	{
		public ICar CreateCar()
		{
			return new Sedan();
		}
	}

	class SUVFactory : ICarFactory
	{
		public ICar CreateCar()
		{
			return new SUV();
		}
	}
}
