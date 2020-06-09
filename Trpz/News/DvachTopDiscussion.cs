using System;

namespace Trpz.News
{
    public class DvachTopDiscussion : ITopDiscussion
    {
        private string Data { get; set; }

        public DvachTopDiscussion(string data) => Data = data;

        public string DisplayDiscussion() => $"Here we go, the best holywar thread: {Data}";
    }
}