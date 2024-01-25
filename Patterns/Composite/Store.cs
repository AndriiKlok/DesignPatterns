using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Composite
{
	abstract class Item
	{
		public abstract decimal GetPrice();
		public virtual void Add(Item item)
		{
			throw new NotImplementedException();
		}
		public virtual void Remove(Item item)
		{
			throw new NotImplementedException();
		}
	}

	class Chips : Item
	{
		public override decimal GetPrice()
		{
			return 4;
		}
	}

	class Nachos : Item
	{
		public override decimal GetPrice()
		{
			return 5;
		}
	}

	class Juice : Item
	{
		public override decimal GetPrice()
		{
			return 3;
		}
	}

	class Pack : Item
	{
		protected List<Item> _items = new List<Item>();

		public override void Add(Item item)
		{
			_items.Add(item);
		}

		public override void Remove(Item item)
		{
			_items.Remove(item);
		}

		public override decimal GetPrice()
		{
			return _items.Sum(item => item.GetPrice());
		}
	}
}
