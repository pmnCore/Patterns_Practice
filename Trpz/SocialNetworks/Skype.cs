using System;

namespace Trpz.SocialNetworks
{
    public class Skype : ISocialNetwork
    {
        public void SendMessageOfBeingLate(TimeSpan time, object target) => Console.WriteLine($"Skype: Message about being late at {time.Minutes} minutes has sent to {target.ToString()}");

        public void SendMessageWithADelay(string message, TimeSpan time, object target) => Console.WriteLine($"Skype: '{message}' will be send to {target.ToString()} after {time.Minutes} minutes.");
        
        public void StandAfk() => Console.WriteLine("Skype: AFK mode enabled.");

        public void StandDontDisturb() => Console.WriteLine("Skype: Don't disturb mode enabled.");

        public void StandOnline() => Console.WriteLine("Skype: Online mode enabled.");
    }
    
}