using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDPDemo.Model
{
    internal class RemoteControl
    {
        private ICommand _command;
        public RemoteControl(ICommand command)
        {
            _command = command;
        }

        public void pressButton()
        {
            _command.Execute();
        }
    }
}
