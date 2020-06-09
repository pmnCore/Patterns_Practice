using System;

namespace Trpz.News
{
    public class DvachNews : INews
    {
        private string Data { get; set; }

        public DvachNews(string data) => Data = data;

        public string DisplayNews() => $"Displaying news from 2ch.hk: {Data}";
    }
}