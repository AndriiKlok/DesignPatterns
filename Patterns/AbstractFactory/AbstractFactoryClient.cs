using System;

namespace Patterns.AbstractFactory
{
	class AbstractFactoryClient
	{
        public AbstractFactoryClient(ICarFactory factory)
        {
            var car = factory.CreateCar();
            Console.WriteLine($"Created a {car.Name}");
        }
    }
}
