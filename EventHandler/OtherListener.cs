using System;

public class OtherListener
{
    public void WordChanged(object sender, ChangeWordEventArgs e)
    {
        Console.WriteLine($"das neue word ist:{e.Word}");
    }
}
