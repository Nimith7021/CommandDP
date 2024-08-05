using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDPDemo.Model
{
    internal class OnCommand : ICommand
    {
        private Television _Tv;
        public OnCommand(Television tv)
        {
            _Tv = tv;
        }

        public void Execute()
        {
            _Tv.On();
        }
    }
}
