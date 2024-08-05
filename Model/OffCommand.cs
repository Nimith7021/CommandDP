using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDPDemo.Model
{
    internal class OffCommand:ICommand
    {
        private Television _Tv;
        public OffCommand(Television tv)
        {
            _Tv = tv;
        }

        public void Execute()
        {
            _Tv.Off();
        }
    }
}
