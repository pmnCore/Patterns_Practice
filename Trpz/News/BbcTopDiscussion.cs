using System;

namespace Trpz.News
{
    public class BbcTopDiscussion : ITopDiscussion
    {
        private string Data { get; set; }

        public BbcTopDiscussion(string data) => Data = data;

        public string DisplayDiscussion() => $"BBC top discussion: {Data}";
    }
}