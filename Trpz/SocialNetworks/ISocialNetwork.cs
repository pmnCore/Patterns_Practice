using System;

namespace Trpz.SocialNetworks
{
    public interface ISocialNetwork
    {
        void SendMessageOfBeingLate(TimeSpan time, object target);
       
        void SendMessageWithADelay(string message, TimeSpan time, object target);
        
        void StandAfk();
        
        void StandDontDisturb();
        
        void StandOnline();
    }
}