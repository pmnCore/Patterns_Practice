namespace Trpz.SocialNetworks
{
    public class DiscordStatusSetter : IStatusSetter
    {
        private Discord Discord { get; set; } = new Discord();

        public string StandAfk() => Discord.StandInAfk();

        public string StandDontDisturb() => Discord.StandInDontDisturb();

        public string StandOnline() => Discord.StandInOnline();
    }
}