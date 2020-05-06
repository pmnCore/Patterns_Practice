using System;

namespace Trpz.SocialNetworks
{
    public interface IMessageSender
    {
        void SendMessageOfBeingLate(TimeSpan time, object target);
        void SendMessageWithADelay(string message, TimeSpan time, object target);
    }
}