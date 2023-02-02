public class Utils 
{
    public static string GetHostFromUrl(string url)
    {
        var uri = new Uri(url);
        return uri.Host;
    }
}