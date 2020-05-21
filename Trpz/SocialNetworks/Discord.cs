using System;

namespace Trpz.SocialNetworks
{
    //3rd party lib
    public sealed class Discord
    {
        public void SendASystemMessageOfBeingLate(string comment, TimeSpan time, object target) => Console.WriteLine($"Discord: Message about being late at {time.Minutes} minutes has sent to {target.ToString()} with comment: '{comment}'.");
        
        public void SendToSomeoneMessageWithADelay(string message, TimeSpan time, object target) => Console.WriteLine($"Discord: '{message}' will be send to {target.ToString()} after {time.Minutes} minutes.");
        
        public void StandInAfk() => Console.WriteLine("Discord: AFK mode enabled.");

        public void StandInDontDisturb() => Console.WriteLine("Discord: Don't disturb mode enabled.");

        public void StandInOnline() => Console.WriteLine("Discord: Online mode enabled.");

        public void LogIn() => Console.WriteLine("Discord: Logged in.");

        public void LogOut() => Console.WriteLine("Discord: Logged out.");

        public void ComplexMethod() => Console.WriteLine("ComplexMethod has been executed");
    }
}