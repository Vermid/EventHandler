using System;
using MyChangeWordEvent;
using OtherListeners;

namespace EventHandlerZaim
{
    public class Neighbor : Listener
    {
        public override void WordChanged(object sender, ChangeWordEventArgs e)
        {
            Console.WriteLine($"This is the Class: Neighbor");
            Console.WriteLine($"MultiCast Delegate:{e.Word}");
        }
    }
}
