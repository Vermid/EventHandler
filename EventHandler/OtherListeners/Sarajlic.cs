using System;
using MyChangeWordEvent;

namespace OtherListeners
{
    public class Sarajlic : Listener
    {
        public override void WordChanged(object sender, ChangeWordEventArgs e)
        {
            Console.WriteLine($"This is the Class: Sarajlic");
            Console.WriteLine($"das neue word ist:{e.Word}");
        }
    }
}
