using System;

namespace Trpz.SocialNetworks
{
    public class DiscordMessageSender : IMessageSender
    {
        private Discord Discord { get; set; } = new Discord();

        public void SendMessageOfBeingLate(string comment, TimeSpan time, object target) => Discord.SendASystemMessageOfBeingLate(comment, time, target);

        public void SendMessageWithADelay(string message, TimeSpan time, object target) => Discord.SendToSomeoneMessageWithADelay(message, time, target);
    }
}