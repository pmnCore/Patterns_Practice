using System;
using System.Collections.Generic;

namespace Trpz
{
    class Program
    {
        static void Main(string[] args)
        {
            ////receiver initialization
            //IParser dvach = new DvachParser();
            //dvach.SetParseType(new JsonParse());

            ////command initialization
            //ICommand showNewsCommand = new ShowNews(dvach);

            //AutomationTool.SetAction(showNewsCommand);
            //dvach.SetParseType(new XmlParse());
            //AutomationTool.ExecuteAction();

            //IParser bbc = new BbcParser();
            //bbc.SetParseType(new JsonParse());
            //ICommand topDiscussionJson = new ShowTopDiscussion(bbc);
            //AutomationTool.SetAction(topDiscussionJson);
            //AutomationTool.ExecuteAction();

            //bbc.SetParseType(new XmlParse());
            //ICommand topDiscussionXml = new ShowTopDiscussion(bbc);
            //AutomationTool.SetAction(topDiscussionXml);
            //AutomationTool.ExecuteAction();

            ////facade receiver
            //IStatusSetter skypeStatusSetter = new SkypeStatusSetter(new Skype());
            ////command
            //ICommand standAfk = new StandAfk(skypeStatusSetter);
            //AutomationTool.SetAction(standAfk);
            //AutomationTool.ExecuteAction();

            ////facade receiver
            //IMessageSender discordMessageSender = new DiscordMessageSender();
            ////command
            //ICommand sendMessageWithADelay = new SendMessageWithADelay(discordMessageSender, "i still at work", new TimeSpan(0, 0, 40, 0), "Vasya and another dodiks");
            //AutomationTool.SetAction(sendMessageWithADelay);
            //AutomationTool.ExecuteAction();

            //List<string> commandList = new List<string>()
            //{
            //    "send discord delay 4 Vasyan 'NIAAAAA'", "+",
            //    "set skype online", "+",
            //    "news bbc json", "+",
            //    "send skype beinglate 10 Jora 'boomer umer'", "+",
            //    "topic dvach xml"
            //};

            Context context = new Context();
            //IExpression expression = context.Evaluate(commandList);
            IExpression expression = context.Evaluate("send discord delay 4 Vasyan 'NIAAAAA' + " +
                                                      "set skype online + " +
                                                      "news bbc xml + " +
                                                      "send skype beinglate 10 Jora 'boomer umer' + " +
                                                      "topic dvach xml");
            string result = expression.Interpret();
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
