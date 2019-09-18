using System.Web;

public class PostHandler : IHttpHandler
{
    public bool IsReusable { get => true; }

    public void ProcessRequest(HttpContext context)
    {
        var a = context.Request.Params.Get("a");
        var b = context.Request.Params.Get("b");

        context.Response.Write($"PostHandler: a = {a}, b = {b}");
    }
}