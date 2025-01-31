﻿using CommandDPDemo.Model;

namespace CommandDPDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Television tv = new Television();
            ICommand command = new OnCommand(tv);
            RemoteControl remoteControl = new RemoteControl();
            remoteControl.SetCommand(command);
            remoteControl.pressButton();
            command = new OffCommand(tv);
            remoteControl = new RemoteControl();
            remoteControl.SetCommand(command);
            remoteControl.pressButton();
        }
    }
}
