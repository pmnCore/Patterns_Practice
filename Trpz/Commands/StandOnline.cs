using Trpz.SocialNetworks;

namespace Trpz.Commands
{
    public class StandOnline : ICommand
    {
        private IStatusSetter Receiver { get; set; }

        public StandOnline(IStatusSetter receiver) => Receiver = receiver;

        public void Execute() => Receiver.StandOnline();
    }
}