using Trpz.News.ParseTypes;

namespace Trpz.News
{
    public interface IParser
    {
        void SetParseType(IParseType type);

        INews GetNews();

        ITopDiscussion GeTopDiscussion();
    }
}