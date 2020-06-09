namespace Trpz.SocialNetworks
{
    public class SkypeStatusSetter : IStatusSetter
    {
        private Skype Skype { get; set; }=new Skype();

        public string StandAfk() => Skype.AfkMode();

        public string StandDontDisturb() => Skype.DontDisturbMode();

        public string StandOnline() => Skype.OnlineMode();
    }
}