using Trpz.SocialNetworks;

namespace Trpz.Commands
{
    public class StandAfk : ICommand
    {
        private IStatusSetter Receiver { get; set; }

        public StandAfk(IStatusSetter receiver) => Receiver = receiver;

        public string Execute() => Receiver.StandAfk();
    }
}