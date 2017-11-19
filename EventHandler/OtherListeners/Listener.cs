using MyChangeWordEvent;

namespace OtherListeners
{
    public abstract class Listener
    {
        public abstract void WordChanged(object sender, ChangeWordEventArgs e);
    }
}
