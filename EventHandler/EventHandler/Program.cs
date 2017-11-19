using System;
using ZaimWord;
using OtherListeners;

namespace EventHandlerZaim
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Instance
            Word word = new Word();
            Zaim zaim = new Zaim();
            Sarajlic sarajlic = new Sarajlic();
            Neighbor neighbor = new Neighbor();
            #endregion

            //add events or Listener
            word.WordChanged += zaim.WordChanged;
            //Mulitcast 
            word.WordChanged += sarajlic.WordChanged;
            //More MultiCast
            word.WordChanged += neighbor.WordChanged;

            //Change word
            word.ChangeWord("Element");
            word.ChangeWord("WhitePad");

            Console.ReadKey();
        }
    }
}


