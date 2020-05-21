using System;
using System.Collections.Generic;
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
            //receiver initialization
            IParser dvach = new DvachParser();
            dvach.SetParseType(new JsonParse());

            //command initialization
            ICommand showNewsCommand = new ShowNews(dvach);

            AutomationTool.SetAction(showNewsCommand);
            dvach.SetParseType(new XmlParse());
            AutomationTool.ExecuteAction();

            IParser bbc = new BbcParser();
            bbc.SetParseType(new JsonParse());
            ICommand topDiscussionJson = new ShowTopDiscussion(bbc);
            AutomationTool.SetAction(topDiscussionJson);
            AutomationTool.ExecuteAction();

            bbc.SetParseType(new XmlParse());
            ICommand topDiscussionXml = new ShowTopDiscussion(bbc);
            AutomationTool.SetAction(topDiscussionXml);
            AutomationTool.ExecuteAction();

            //facade receiver
            IStatusSetter skypeStatusSetter = new SkypeStatusSetter(new Skype());
            //command
            ICommand standAfk = new StandAfk(skypeStatusSetter);
            AutomationTool.SetAction(standAfk);
            AutomationTool.ExecuteAction();

            //facade receiver
            IMessageSender discordMessageSender = new DiscordMessageSender(new Discord());
            //command
            ICommand sendMessageWithADelay = new SendMessageWithADelay(discordMessageSender, "i still at work", new TimeSpan(0, 0, 40, 0), "Vasya and another dodiks");
            AutomationTool.SetAction(sendMessageWithADelay);
            AutomationTool.ExecuteAction();

            //List<string> commandList = new List<string>();
            //commandList.Add("skype afk");
            //commandList.Add("+");
            //commandList.Add("skype online");
            //Context context = new Context();
            //IExpression expression = context.Evaluate(commandList);
            //expression.Interpret();
            Console.ReadKey();
        }
    }
}
