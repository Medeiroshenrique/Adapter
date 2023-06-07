namespace Bridge;

public class Movies: IChannel
{
    public string Channel()
    {
        return "Synchronized with movies channel";
    }

    public string Status()
    {
        return "You are watching-> Zack Snyder's Justice League";
    }
}