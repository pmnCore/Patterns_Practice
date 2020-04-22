namespace Trpz.SocialNetworks
{
    //interface ref only in case of editable classes
    //facade - in case of using 3rd person libraries
    public class SocialNetworkStatusSetter
    {
        private ISocialNetwork SocialNetwork { get; set; }

        public SocialNetworkStatusSetter(ISocialNetwork network) => SocialNetwork = network;

        public void SetNetwork(ISocialNetwork network) => SocialNetwork = network;

        public void StandAfk() => SocialNetwork.StandAfk();
        
        public void StandDontDisturb() => SocialNetwork.StandDontDisturb();
        
        public void StandOnline() => SocialNetwork.StandOnline();
    }
}