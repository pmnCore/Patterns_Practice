using Trpz.Commands;
using Trpz.News;
using Trpz.News.ParseTypes;
using Trpz.SocialNetworks;

namespace Trpz
{
    public class CommandExpression : IExpression
    {
        private string Command { get; set; }
        public CommandExpression(string command) => Command = command;

        public void Interpret()
        {
            switch (Command.ToLower())
            {
                case "skype afk":
                    //IStatusSetter skypeStatusSetter = new SkypeStatusSetter(new Skype());
                    //ICommand standAfk = new StandAfk(skypeStatusSetter);
                    //AutomationTool.SetAction(standAfk);
                    //AutomationTool.ExecuteAction();
                    AutomationTool.SetAction(new StandAfk(new SkypeStatusSetter(new Skype())));
                    AutomationTool.ExecuteAction();
                    break;
                case "skype don't disturb":
                    AutomationTool.SetAction(new StandDontDisturb(new SkypeStatusSetter(new Skype())));
                    AutomationTool.ExecuteAction();
                    break;
                case "skype online":
                    AutomationTool.SetAction(new StandOnline(new SkypeStatusSetter(new Skype())));
                    AutomationTool.ExecuteAction();
                    break;
            }
        }
    }
}