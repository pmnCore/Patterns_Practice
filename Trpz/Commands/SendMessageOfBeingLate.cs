using System;
using Trpz.SocialNetworks;

namespace Trpz.Commands
{
    public class SendMessageOfBeingLate : ICommand
    {
        private IMessageSender Receiver { get; set; }
        private TimeSpan Time { get; set; }
        private object Target { get; set; }

        public SendMessageOfBeingLate(IMessageSender receiver, TimeSpan time, object target)
        {
            Receiver = receiver;
            Time = time;
            Target = target;
        }

        public void Execute() => Receiver.SendMessageOfBeingLate(Time, Target);
    }
}