using System;
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

        public string Interpret()
        {
            string[] commandParameters = SplitCommandString(out string message);
            ICommand command = GetCommand(commandParameters, message);
            AutomationTool.SetAction(command);
            return AutomationTool.ExecuteAction();
            
        }

        string[] SplitCommandString(out string message)
        {
            string[] commandValues = Command.Split(new[] { '\'' }, StringSplitOptions.RemoveEmptyEntries);
            string command = commandValues[0];
            if (commandValues.Length != 1) message = commandValues[1];
            else message = null;

            return command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        IParser GetParser(string value)
        {
            switch (value.ToLower())
            {
                case "bbc": return new BbcParser();
                case "dvach":return new DvachParser();
                default:
                    return null;
            }
        }

        IParseType GetParseType(string value)
        {
            switch (value.ToLower())
            {
                case "json": return new JsonParse();
                case "xml": return new XmlParse();
                default:
                    return null;
            }
        }

        IMessageSender GetMessageSender(string value)
        {
            switch (value.ToLower())
            {
                case "discord": return new DiscordMessageSender();
                case "skype": return new SkypeMessageSender();
                default:
                    return null;
            }
        }

        ICommand GetMessageSenderCommand(IMessageSender messageSender, string message, string commandValue, string time, string target)
        {
            switch (commandValue.ToLower())
            {
                case "beinglate": return new SendMessageOfBeingLate(messageSender,message, new TimeSpan(0, 0, Convert.ToInt32(time), 0), target);
                case "delay": return new SendMessageWithADelay(messageSender, message, new TimeSpan(0, 0, Convert.ToInt32(time), 0), target);
                default:
                    return null;
            }
        }

        IStatusSetter GetStatusSetter(string value)
        {
            switch (value.ToLower())
            {
                case "discord": return new DiscordStatusSetter();
                case "skype": return new SkypeStatusSetter();
                default:
                    return null;
            }
        }

        ICommand GetStatusSetterCommand(IStatusSetter statusSetter, string value)
        {
            switch (value.ToLower())
            {
                case "afk": return new StandAfk(statusSetter);
                case "online": return new StandOnline(statusSetter);
                case "dontdisturb": return new StandDontDisturb(statusSetter);
                default:
                    return null;
            }
        }

        ICommand GetCommand(string[] commandParameters, string message)
        {
            IParser parser = null;
            int position = 0;
            switch (commandParameters[position].ToLower())
            {
                case "news":
                    position++;
                    parser = GetParser(commandParameters[position].ToLower());

                    position++;
                    parser.SetParseType(GetParseType(commandParameters[position]));
                    return new ShowNews(parser);

                case "topic":
                    position++;
                    parser = GetParser(commandParameters[position].ToLower());

                    position++;
                    parser.SetParseType(GetParseType(commandParameters[position]));
                    return new ShowTopDiscussion(parser);

                case "send":
                    position++;
                    IMessageSender messageSender = GetMessageSender(commandParameters[position]);

                    position++;
                    return GetMessageSenderCommand(messageSender, message, commandParameters[position],
                        commandParameters[position + 1], commandParameters[position + 2]);

                case "set":
                    position++;
                    IStatusSetter statusSetter = GetStatusSetter(commandParameters[position]);

                    position++;
                    return GetStatusSetterCommand(statusSetter, commandParameters[position]);
                default:
                    return null;
            }
        }

    }
}