namespace Trpz.SocialNetworks
{
    public class DiscordStatusSetter : IStatusSetter
    {
        private Discord Discord { get; set; } = new Discord();

        public void StandAfk() => Discord.StandInAfk();

        public void StandDontDisturb() => Discord.StandInDontDisturb();

        public void StandOnline() => Discord.StandInOnline();
    }
}