using System;

namespace Trpz.News
{
    public class BbcNews : INews
    {
        private string Data { get; set; }

        public BbcNews(string data) => Data = data;

        public void DisplayNews()
        {
            Console.WriteLine($"BBC news: {Data}");
        }
    }
}