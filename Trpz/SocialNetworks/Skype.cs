using System;

namespace Trpz.SocialNetworks
{
    //3rd party lib
    public sealed class Skype
    {
        public void MessageOfBeingLate(string comment, TimeSpan time, object target) => Console.WriteLine($"Skype: Message about being late at {time.Minutes} minutes has sent to {target.ToString()} with comment: '{comment}'");

        public void MessageWithADelay(string message, TimeSpan time, object target) => Console.WriteLine($"Skype: '{message}' will be send to {target.ToString()} after {time.Minutes} minutes.");
        
        public void AfkMode() => Console.WriteLine("Skype: AFK mode enabled.");

        public void DontDisturbMode() => Console.WriteLine("Skype: Don't disturb mode enabled.");

        public void OnlineMode() => Console.WriteLine("Skype: Online mode enabled.");

        public void LogIn() => Console.WriteLine("Skype: Logged in.");

        public void LogOut() => Console.WriteLine("Skype: Logged out.");

        public void GarbageMethod() => Console.WriteLine("Garbage has been executed");
    }
    
}