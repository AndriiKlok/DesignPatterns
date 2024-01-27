using Patterns.AbstractFactory;
using Patterns.Bridge;
using Patterns.Bridge.Abstract;
using Patterns.Builder;
using Patterns.Composite;
using Patterns.Decorator;
using Patterns.FactoryMethod;
using Patterns.Mediator;
using Patterns.Prototype;
using System;
using System.Collections.Generic;

namespace Patterns
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Singleton
			var instance = Singleton.Instance;

			//FactoryMethod
			Console.WriteLine("<==Factory method==>");
			List<Document> documents = new List<Document>();
			documents.Add(new Resume());
			documents.Add(new Report());
			showFactory(documents);

			//AbstractFactory
			Console.WriteLine("\n<==Abstract factory==>");
			new AbstractFactoryClient(new SedanFacory());
			new AbstractFactoryClient(new SUVFactory());

			//Bridge
			Console.WriteLine("\n<==Bridge==>");
			AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
			longMessage.SendMessage("long message!");

			AbstractMessage shortMessae = new ShortMessage(new SmsMessageSender());
			shortMessae.SendMessage("short sms!");

			//Mediator
			Console.WriteLine("\n<==Mediator==>");
			var mediator = new ConcreteMediator();
			var c1 = new Colleague1();
			var c2 = new Colleague2();

			mediator.Register(c1);
			mediator.Register(c2);

			c1.Send("hello");
			c2.Send("hi");

			c1.Send("bye");
			c2.Send("bye bye");

			//Decorator
			Console.WriteLine("\n<==Decorator==>");
			Margherita pizza = new Margherita();
			Console.WriteLine("Margherita: " + pizza.GetPrice().ToString());

			ExtraCheeseTopping moreCheese = new ExtraCheeseTopping(pizza);
			Console.WriteLine("Margherita with extra cheese: " + moreCheese.GetPrice().ToString());

			MushroomTopping moreMushroom = new MushroomTopping(moreCheese);
			Console.WriteLine("Margherita with extra cheese + mushrooms: " + moreMushroom.GetPrice().ToString());

			JalapenoTopping moreJalapeno = new JalapenoTopping(moreMushroom);
			Console.WriteLine("Margherita with extra cheese + mushrooms + jalapeno: " + moreJalapeno.GetPrice().ToString());

			//Composite
			Console.WriteLine("\n<==Composite==>");
			Pack pack = new Pack();
			pack.Add(new Chips());
			pack.Add(new Nachos());
			pack.Add(new Juice());

			Console.Write($"Total: {pack.GetPrice()}\n");

			//Protorype
			Console.WriteLine($"\n<==Prototype==>");
			Person p1 = new Person()
			{
				Name = "Person 1",
				Age = 20,
				AdditionalInfo = new AdditionalInfo()
				{
					FavoriteNumber = 1
				}
			};
			Person p2 = p1.ShallCopy();
			Person p3 = p1.DeepCopy();

			showPrototype(new List<Person> { p1, p2, p3 }, "before changes");

			p1.Age = 21;
			p1.Name = "Person n";
			p1.AdditionalInfo.FavoriteNumber = 2;

			showPrototype(new List<Person> { p1, p2, p3 }, "after changes");

			//Builder
			Console.WriteLine($"\n<==Builder==>");
			var builder = new ConcreteBuilder();
			builder.BuildPartA();
			builder.BuildPartB();
			builder.BuildPartC();

			var product = builder.GetProduct();
			product.ListParts();

			Console.ReadLine();
		}

		static void showFactory(List<Document> documents)
		{
			foreach (var document in documents)
			{
				Console.WriteLine(document.GetType().Name + ":");
				foreach (var page in document.Pages)
				{
					Console.WriteLine(" " + page.GetType().Name);
				}
			}
		}

		static void showPrototype(List<Person> people, string option)
		{
			Console.WriteLine($"{option}:");
			foreach (var person in people)
			{
				Console.WriteLine($"{person.Name}: {person.Age} years old, favorite number {person.AdditionalInfo.FavoriteNumber}.");
			}
		}


	}
}
