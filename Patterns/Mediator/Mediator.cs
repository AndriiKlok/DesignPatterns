using System;
using System.Collections.Generic;
using System.Linq;

namespace Patterns.Mediator
{
	abstract class Mediator
	{
		public abstract void Send(string message, Colleague colleague);
	}

	abstract class Colleague
	{
		public Mediator Mediator { get; set; }
		public virtual void Send(string message) => Mediator.Send(message, this);
		public abstract void Receive(string message);
	}

	class Colleague1 : Colleague
	{
		public override void Receive(string message) => Console.WriteLine($"Colleague1 received: {message}");
	}

	class Colleague2 : Colleague
	{
		public override void Receive(string message) => Console.WriteLine($"Colleague2 received: {message}");
	}

	class ConcreteMediator : Mediator
	{
		private readonly List<Colleague> _colleagues = new List<Colleague>();

		public void Register(Colleague colleague)
		{
			colleague.Mediator = this;
			_colleagues.Add(colleague);
		}

		public override void Send(string message, Colleague receiver)
		{
			_colleagues
				.Where(c => c != receiver)
				.ToList()
				.ForEach(c => c.Receive(message));
		}
	}
}
