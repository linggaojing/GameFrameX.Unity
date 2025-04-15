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

    public static string HttpPort = "28080";//http端口
    public static string APIWebSocketPort = "20808";//api中的websocket端口
    public static string TcpPort = "29100";
    public static string ServerWebSocketPort = "29110";//server中websocket端口

}