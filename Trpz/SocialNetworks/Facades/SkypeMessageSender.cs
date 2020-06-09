using System;

namespace Trpz.SocialNetworks
{
    public class SkypeMessageSender : IMessageSender
    {
        private Skype Skype { get; set; } = new Skype();

        public string SendMessageOfBeingLate(string comment, TimeSpan time, object target) => Skype.MessageOfBeingLate(comment, time, target);

        public string SendMessageWithADelay(string message, TimeSpan time, object target) => Skype.MessageWithADelay(message, time, target);
    }
}