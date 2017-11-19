using System;
using MyChangeWordEvent;

namespace ZaimWord
{
    public class Word
    {
        private string myWord;
        public delegate void ChangeWordEventHandler(object sender, ChangeWordEventArgs e);
        public event ChangeWordEventHandler WordChanged;

        public void ChangeWord(string txt)
        {
            Console.WriteLine($"Word is Changed from {(myWord ?? "null")} to {txt}");
            myWord = txt;
            OnWordChange();
        }

        public virtual void OnWordChange()
        {
            //does it have listener?
            if (WordChanged != null)
            {
                ChangeWordEventArgs args = new ChangeWordEventArgs()
                {
                    Word = myWord
                };
                WordChanged(this, args);
            }
        }
    }
}