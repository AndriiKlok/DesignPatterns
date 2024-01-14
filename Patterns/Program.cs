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
