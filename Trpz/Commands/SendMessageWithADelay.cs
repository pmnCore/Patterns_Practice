using System;
using Trpz.SocialNetworks;

namespace Trpz.Commands
{
    public class SendMessageWithADelay
    {
        private MessageSender SocialNetwork { get; set; }
        private string Message { get; set; }
        private TimeSpan Time { get; set; }
        private object Target { get; set; }

        public SendMessageWithADelay(MessageSender socialNetwork, string message, TimeSpan time, object target)
        {
            SocialNetwork = socialNetwork;
            Message = message;
            Time = time;
            Target = target;
        }

        public void Execute() => SocialNetwork.SendMessageWithADelay(Message, Time, Target);
    }
}