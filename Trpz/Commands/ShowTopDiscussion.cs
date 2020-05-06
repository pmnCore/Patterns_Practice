﻿using Trpz.News;

namespace Trpz.Commands
{
    public class ShowTopDiscussion : ICommand
    {
        IParser Receiver { get; set; }

        public ShowTopDiscussion(IParser receiver) => Receiver = receiver;

        public void Execute() => Receiver.GetNews().DisplayNews();
    }
}