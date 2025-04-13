public class AppConst
{
    public static bool UseLocalHost = false;

    public static string IP
    {
        get
        {
            if (UseLocalHost)
            {
                return "127.0.0.1";
            }
            else
            {
                return "8.148.225.3";
            }
        }
    }

    public static string HttpPort = "28080";
    public static string WebSocketPort = "20808";

}