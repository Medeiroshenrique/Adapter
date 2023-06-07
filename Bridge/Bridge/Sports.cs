namespace Bridge;

public class Sports: IChannel
{
    public string Channel()
    {
        return "Synchronized with the sports channel";
    }

    public string Status()
    {
        return "You are watching-> FIFA world cup 2026";
    }
}