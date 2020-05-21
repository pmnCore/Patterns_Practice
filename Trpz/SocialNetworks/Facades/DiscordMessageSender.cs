using System;

namespace Trpz.SocialNetworks
{
    public class DiscordMessageSender : IMessageSender
    {
        private Discord Discord { get; set; }

        public DiscordMessageSender(Discord discord) => Discord = discord;

        public void SendMessageOfBeingLate(TimeSpan time, object target) => Discord.SendASystemMessageOfBeingLate(time, target);

        public void SendMessageWithADelay(string message, TimeSpan time, object target) => Discord.SendToSomeoneMessageWithADelay(message, time, target);
    }
}