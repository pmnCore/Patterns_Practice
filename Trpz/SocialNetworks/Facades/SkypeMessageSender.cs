using System;

namespace Trpz.SocialNetworks
{
    public class SkypeMessageSender : IMessageSender
    {
        private Skype Skype { get; set; } = new Skype();

        public void SendMessageOfBeingLate(string comment, TimeSpan time, object target) => Skype.MessageOfBeingLate(comment, time, target);

        public void SendMessageWithADelay(string message, TimeSpan time, object target) => Skype.MessageWithADelay(message, time, target);
    }
}