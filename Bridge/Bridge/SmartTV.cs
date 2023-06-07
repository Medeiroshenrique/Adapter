namespace Bridge;

public class SmartTV
{
    public IChannel currentChannel { get; set; }

    public void ShowSynchronizedChannel()
    {
        if (currentChannel != null)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(currentChannel.Channel());
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not synchronized with any channel, please choose one!");
            Console.ResetColor();
        }
    }

    public void PlayTV()
    {
        if(currentChannel != null)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(currentChannel.Status());
                Console.ResetColor(); 
        }else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Not synchronized with any channel, please choose one!");
            Console.ResetColor();
        }
    }
}
