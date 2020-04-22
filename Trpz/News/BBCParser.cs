using Trpz.News.ParseTypes;

namespace Trpz.News
{
    public class BbcParser : IParser
    {
        IParseType ParseType { get; set; }

        public void SetParseType(IParseType type) => ParseType = type;

        public INews GetNews() => new BbcNews(ParseType.Parse());

        public ITopDiscussion GeTopDiscussion() => new BbcTopDiscussion(ParseType.Parse());
    }
}