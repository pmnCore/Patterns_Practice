﻿using Trpz.SocialNetworks;

namespace Trpz.Commands
{
    public class StandDontDisturb : ICommand
    {
        private IStatusSetter Receiver { get; set; }

        public StandDontDisturb(IStatusSetter receiver) => Receiver = receiver;

        public void Execute() => Receiver.StandDontDisturb();
    }
}