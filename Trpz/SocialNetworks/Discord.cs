using System;

namespace Trpz.SocialNetworks
{
    //3rd party lib
    public sealed class Discord
    {
        public string SendASystemMessageOfBeingLate(string comment, TimeSpan time, object target) => $"Discord: Message about being late at {time.Minutes} minutes has sent to {target.ToString()} with comment: '{comment}'.";
        
        public string SendToSomeoneMessageWithADelay(string message, TimeSpan time, object target) => $"Discord: '{message}' will be send to {target.ToString()} after {time.Minutes} minutes.";
        
        public string StandInAfk() => "Discord: AFK mode enabled.";

        public string StandInDontDisturb() => "Discord: Don't disturb mode enabled.";

        public string StandInOnline() => "Discord: Online mode enabled.";

        public void LogIn() => Console.WriteLine("Discord: Logged in.");

        public void LogOut() => Console.WriteLine("Discord: Logged out.");

        public void ComplexMethod() => Console.WriteLine("ComplexMethod has been executed");
    }
}