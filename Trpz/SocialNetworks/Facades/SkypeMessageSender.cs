using System;

namespace Trpz.SocialNetworks
{
    public class SkypeMessageSender : IMessageSender
    {
        private Skype Skype { get; set; }

        public SkypeMessageSender(Skype skype) => Skype = skype;


        public void SendMessageOfBeingLate(TimeSpan time, object target) => Skype.MessageOfBeingLate(time, target);

        public void SendMessageWithADelay(string message, TimeSpan time, object target) => Skype.MessageWithADelay(message, time, target);
    }
}