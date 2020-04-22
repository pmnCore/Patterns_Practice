using Trpz.News;
using Trpz.News.ParseTypes;

namespace Trpz.Commands
{
    public class ShowNews : ICommand
    {
        IParser Parser { get; set; }
        IParseType Type { get; set; }

        public ShowNews(IParser parser, IParseType type)
        {
            Parser = parser;
            Type = type;
            Parser.SetParseType(Type);
        }

        public void Execute() => Parser.GetNews().DisplayNews();
    }
}