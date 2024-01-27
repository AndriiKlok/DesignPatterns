using System;
using System.Collections.Generic;

namespace Patterns.Builder
{
	interface IBuilder
	{
		void BuildPartA();
		void BuildPartB();
		void BuildPartC();
	}

	class ConcreteBuilder : IBuilder
	{
		private Product _product = new Product();

		public ConcreteBuilder()
		{
			Reset();
		}
		public void Reset()
		{
			_product = new Product();
		}
		public void BuildPartA()
		{
			_product.Add("PartA");
		}

		public void BuildPartB()
		{
			_product.Add("PartB");
		}

		public void BuildPartC()
		{
			_product.Add("PartC");
		}

		public Product GetProduct()
		{
			Product result = _product;

			this.Reset();

			return result;
		}
	}

	class Product
	{
		private List<string> _parts = new List<string>();
		public void Add(string part)
		{
			_parts.Add(part);
		}
		public void ListParts()
		{
			Console.WriteLine($"Product: {String.Join(", ", _parts)}");
		}
	}
}