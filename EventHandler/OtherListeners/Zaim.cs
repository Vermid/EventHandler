using System;
using MyChangeWordEvent;

namespace OtherListeners
{
    public class Zaim : Listener
    {
        public override void WordChanged(object sender, ChangeWordEventArgs e)
        {
            Console.WriteLine($"This is the Class: Zaim");
            Console.WriteLine($"das neue word ist:{e.Word}");
        }
    }
}
