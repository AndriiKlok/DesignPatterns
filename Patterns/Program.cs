using Patterns.AbstractFactory;
using Patterns.Bridge;
using Patterns.Bridge.Abstract;
using Patterns.FactoryMethod;
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
