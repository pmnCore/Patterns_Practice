using Trpz.SocialNetworks;

namespace Trpz.Commands
{
    public class StandAfk : ICommand
    {
        private SocialNetworkStatusSetter SocialNetwork { get; set; }

        public StandAfk(SocialNetworkStatusSetter socialNetwork) => SocialNetwork = socialNetwork;

        public void Execute() => SocialNetwork.StandAfk();
    }
}