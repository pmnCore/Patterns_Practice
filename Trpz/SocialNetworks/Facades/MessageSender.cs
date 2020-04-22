using System;

namespace Trpz.SocialNetworks
{
    //interface ref only in case of editable classes
    //facade - in case of using 3rd person libraries
    public class MessageSender
    {
        private ISocialNetwork SocialNetwork { get; set; }

        public MessageSender(ISocialNetwork network) => SocialNetwork = network;

        public void SetNetwork(ISocialNetwork network) => SocialNetwork = network;

        public void SendMessageOfBeingLate(TimeSpan time, object target) => SocialNetwork.SendMessageOfBeingLate(time, target);

        public void SendMessageWithADelay(string message, TimeSpan time, object target) => SocialNetwork.SendMessageWithADelay(message, time, target);
    }
}