using System;

namespace Trpz.SocialNetworks
{
    public class Discord : ISocialNetwork
    {
        public void SendMessageOfBeingLate(TimeSpan time, object target) => Console.WriteLine($"Discord: Message about being late at {time.Minutes} minutes has sent to {target.ToString()}.");
        
        public void SendMessageWithADelay(string message, TimeSpan time, object target) => Console.WriteLine($"Discord: '{message}' will be send to {target.ToString()} after {time.Minutes} minutes.");
        
        public void StandAfk() => Console.WriteLine("Discord: AFK mode enabled.");

        public void StandDontDisturb() => Console.WriteLine("Discord: Don't disturb mode enabled.");

        public void StandOnline() => Console.WriteLine("Discord: Online mode enabled.");
    }
}