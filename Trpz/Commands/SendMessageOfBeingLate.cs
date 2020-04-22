using System;
using Trpz.SocialNetworks;

namespace Trpz.Commands
{
    public class SendMessageOfBeingLate : ICommand
    {
        private MessageSender SocialNetwork { get; set; }
        private TimeSpan Time { get; set; }
        private object Target { get; set; }

        public SendMessageOfBeingLate(MessageSender socialNetwork, TimeSpan time, object target)
        {
            SocialNetwork = socialNetwork;
            Time = time;
            Target = target;
        }

        public void Execute() => SocialNetwork.SendMessageOfBeingLate(Time, Target);
    }
}