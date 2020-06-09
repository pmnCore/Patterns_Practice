using System;

namespace Trpz.SocialNetworks
{
    public interface IMessageSender
    {
        string SendMessageOfBeingLate(string comment, TimeSpan time, object target);
        string SendMessageWithADelay(string message, TimeSpan time, object target);
    }
}