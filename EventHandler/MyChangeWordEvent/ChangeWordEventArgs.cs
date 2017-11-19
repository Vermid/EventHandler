using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChangeWordEvent
{
        public class ChangeWordEventArgs : EventArgs
        {
            public string Word { get; set; }
        }
}
