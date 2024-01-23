using Patterns.AbstractFactory;
using Patterns.Bridge;
using Patterns.Bridge.Abstract;
using Patterns.Decorator;
using Patterns.FactoryMethod;
using Patterns.Mediator;
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
			List<Document> documents = new List<Document>();
			documents.Add(new Resume());
			documents.Add(new Report());

			//AbstractFactory
			new AbstractFactoryClient(new SedanFacory());
			new AbstractFactoryClient(new SUVFactory());

			//Bridge
			AbstractMessage longMessage = new LongMessage(new EmailMessageSender());
			longMessage.SendMessage("long message!");

			AbstractMessage shortMessae = new ShortMessage(new SmsMessageSender());
			shortMessae.SendMessage("short sms!");

			//Mediator
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
			Margherita pizza = new Margherita();
			Console.WriteLine("Margherita: " + pizza.GetPrice().ToString());

			ExtraCheeseTopping moreCheese = new ExtraCheeseTopping(pizza);
			Console.WriteLine("Margherita with extra cheese: " + moreCheese.GetPrice().ToString());

			MushroomTopping moreMushroom = new MushroomTopping(moreCheese);
			Console.WriteLine("Margherita with extra cheese + mushrooms: " + moreMushroom.GetPrice().ToString());

			JalapenoTopping moreJalapeno = new JalapenoTopping(moreMushroom);
			Console.WriteLine("Margherita with extra cheese + mushrooms + jalapeno: " + moreJalapeno.GetPrice().ToString());


			Console.ReadLine();
		}

		void showFactory(List<Document> documents)
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


	}
}
