namespace Trpz.SocialNetworks
{
    public class DiscordStatusSetter : IStatusSetter
    {
        private Discord Discord { get; set; }

        public DiscordStatusSetter(Discord discord) => Discord = discord;

        public void StandAfk() => Discord.StandInAfk();

        public void StandDontDisturb() => Discord.StandInDontDisturb();

        public void StandOnline() => Discord.StandInOnline();
    }
}