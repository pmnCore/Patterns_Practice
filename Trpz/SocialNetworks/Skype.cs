using System;

namespace Trpz.SocialNetworks
{
    //3rd party lib
    public sealed class Skype
    {
        public string MessageOfBeingLate(string comment, TimeSpan time, object target) => $"Skype: Message about being late at {time.Minutes} minutes has sent to {target.ToString()} with comment: '{comment}'";

        public string MessageWithADelay(string message, TimeSpan time, object target) => $"Skype: '{message}' will be send to {target.ToString()} after {time.Minutes} minutes.";
        
        public string AfkMode() => "Skype: AFK mode enabled.";

        public string DontDisturbMode() => "Skype: Don't disturb mode enabled.";

        public string OnlineMode() => "Skype: Online mode enabled.";

        public void LogIn() => Console.WriteLine("Skype: Logged in.");

        public void LogOut() => Console.WriteLine("Skype: Logged out.");

        public void GarbageMethod() => Console.WriteLine("Garbage has been executed");
    }
    
}