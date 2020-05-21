namespace Trpz.SocialNetworks
{
    public class SkypeStatusSetter : IStatusSetter
    {
        private Skype Skype { get; set; }

        public SkypeStatusSetter(Skype skype) => Skype = skype;

        public void StandAfk() => Skype.AfkMode();

        public void StandDontDisturb() => Skype.DontDisturbMode();

        public void StandOnline() => Skype.OnlineMode();
    }
}