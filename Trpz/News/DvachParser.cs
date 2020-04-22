using Trpz.News.ParseTypes;

namespace Trpz.News
{
    public class DvachParser : IParser
    {
        IParseType ParseType { get; set; }

        public void SetParseType(IParseType type) => ParseType = type;

        public INews GetNews() => new DvachNews(ParseType.Parse());

        public ITopDiscussion GeTopDiscussion() => new DvachTopDiscussion(ParseType.Parse());
    }
}