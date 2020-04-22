using System;

namespace Trpz.SocialNetworks
{
    public class ISQ : ISocialNetwork 
    {
        public void SendMessageOfBeingLate(TimeSpan time, object target) => Console.WriteLine($"ISQ: Message about being late at {time.Minutes} minutes has sent to {target.ToString()}.");
       
        public void SendMessageWithADelay(string message, TimeSpan time, object target) => Console.WriteLine($"ISQ: '{message}' will be send to {target.ToString()} after {time.Minutes} minutes.");
        
        public void StandAfk() => Console.WriteLine("ISQ: AFK mode enabled.");

        public void StandDontDisturb() => Console.WriteLine("ISQ: Don't disturb mode enabled.");

        public void StandOnline() => Console.WriteLine("ISQ: Online mode enabled.");
    }
}