using System.Web;

public class SumHandler : IHttpHandler
{
    public bool IsReusable { get => true; }

    public void ProcessRequest(HttpContext context)
    {
        try
        {
            var x = int.Parse(context.Request.Params.Get("x"));
            var y = int.Parse(context.Request.Params.Get("y"));

            context.Response.Write((x + y).ToString());
        }
        catch
        {
            context.Response.Write("Ошибка");
        }
    }
}