using Patterns.Bridge.Interface;
using System;

namespace Patterns.Bridge.Abstract
{
	class ShortMessage : AbstractMessage
	{
        public ShortMessage(IMessageSender messageSender)
        {
			this.messageSender = messageSender;
        }

        public override void SendMessage(string message)
		{
			if(message.Length <= 10)
			{
				messageSender.SendMessage(message);
			}
			else
			{
				Console.WriteLine("to long message");
			}
		}
	}
}
