﻿using Trpz.News;

namespace Trpz.Commands
{
    public class ShowNews : ICommand
    {
        IParser Receiver { get; set; }

        public ShowNews(IParser receiver) => Receiver = receiver;

        public string Execute() => Receiver.GetNews().DisplayNews();
    }
}