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

        //TODO: scripts in WoW (trinket->blind, vanish->sap, sap spammer, blind catching....) (additional)

        static void Main(string[] args)
        {
            AutomationTool tool = new AutomationTool();
            tool.SetAction(new ShowNews(new DvachParser(), new ApiParse()));
            tool.ExecuteAction();
            tool.SetAction(new StandAfk(new SocialNetworkStatusSetter(new ISQ())));
            tool.ExecuteAction();
            tool.SetAction( new SendMessageOfBeingLate(new MessageSender(new Discord()), new TimeSpan(0,0,20,0), "Vasya and another dodiks" ));
            tool.ExecuteAction();
            Console.ReadKey();
        }
    }
}
