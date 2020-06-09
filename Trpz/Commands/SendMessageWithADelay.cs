using System;
using Trpz.SocialNetworks;

namespace Trpz.Commands
{
    public class SendMessageWithADelay : ICommand
    {
        private IMessageSender Receiver { get; set; }
        private string Message { get; set; }
        private TimeSpan Time { get; set; }
        private object Target { get; set; }

        public SendMessageWithADelay(IMessageSender receiver, string message, TimeSpan time, object target)
        {
            Receiver = receiver;
            Message = message;
            Time = time;
            Target = target;
        }

        public string Execute() => Receiver.SendMessageWithADelay(Message, Time, Target);
    }
}