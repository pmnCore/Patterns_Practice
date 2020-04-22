using Trpz.News;
using Trpz.News.ParseTypes;

namespace Trpz.Commands
{
    public class ShowTopDiscussion : ICommand
    {
        IParser Parser { get; set; }
        IParseType Type { get; set; }

        public ShowTopDiscussion(IParser parser, IParseType type)
        {
            Parser = parser;
            Type = type;
            Parser.SetParseType(Type);
        }

        public void Execute() => Parser.GetNews().DisplayNews();
    }
}