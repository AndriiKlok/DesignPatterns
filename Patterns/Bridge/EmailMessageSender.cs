using Patterns.Bridge.Interface;
using System;

namespace Patterns
{
	class EmailMessageSender : IMessageSender
	{
		public void SendMessage(string message)
		{
			Console.WriteLine(message + ": sended by Email");
		}
	}
}
