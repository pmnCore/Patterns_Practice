using System;
using Trpz.Commands;
using Trpz.News;
using Trpz.News.ParseTypes;
using Trpz.SocialNetworks;

namespace Trpz
{
    class Program
    {
        //Strategy, Command, Abstract Factory, Facade, Interpreter

        //TODO: some kind of T9 (pattern Interpreter)
        //after pressing '(' creates ')' instantly and sets '|' between them
        // [] and {} - the same

        //TODO: Task manager (additional)
        //use WaitableTimer to turn on notebook
        //don't disturb mode form 11 pm to 6 am
        //open some sites at 6 am


        static void Main(string[] args)
        {
            AutomationTool tool = new AutomationTool();
            
            //receiver initialization
            IParser dvach = new DvachParser();
            dvach.SetParseType(new JsonParse());
            
            //command initialization
            ICommand showNewsCommand = new ShowNews(dvach);

            tool.SetAction(showNewsCommand);
            dvach.SetParseType(new XmlParse());
            tool.ExecuteAction();

            IParser bbc = new BbcParser();
            bbc.SetParseType(new JsonParse());
            ICommand topDiscussion = new ShowTopDiscussion(bbc);
            tool.SetAction(topDiscussion);
            tool.ExecuteAction();

            //facade receiver
            IStatusSetter skypeStatusSetter = new SkypeStatusSetter(new Skype());
            //command
            ICommand standAfk = new StandAfk(skypeStatusSetter);
            tool.SetAction(standAfk);
            tool.ExecuteAction();

            //facade receiver
            IMessageSender discordMessageSender = new DiscordMessageSender(new Discord());
            //command
            ICommand sendMessageWithADelay = new SendMessageWithADelay(discordMessageSender, "i still at work", new TimeSpan(0, 0, 40, 0), "Vasya and another dodiks");
            tool.SetAction(sendMessageWithADelay);
            tool.ExecuteAction();

            Console.ReadKey();
        }
    }
}
