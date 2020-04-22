using Trpz.SocialNetworks;

namespace Trpz.Commands
{
    public class StandOnline : ICommand
    {
        private SocialNetworkStatusSetter SocialNetwork { get; set; }

        public StandOnline(SocialNetworkStatusSetter socialNetwork) => SocialNetwork = socialNetwork;

        public void Execute() => SocialNetwork.StandOnline();
    }
}