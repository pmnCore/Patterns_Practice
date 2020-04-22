using Trpz.SocialNetworks;

namespace Trpz.Commands
{
    public class StandDontDisturb : ICommand
    {
        private SocialNetworkStatusSetter SocialNetwork { get; set; }

        public StandDontDisturb(SocialNetworkStatusSetter socialNetwork) => SocialNetwork = socialNetwork;

        public void Execute() => SocialNetwork.StandDontDisturb();
    }
}