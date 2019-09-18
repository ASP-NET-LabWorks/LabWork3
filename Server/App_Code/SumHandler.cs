using System.Web;

public class SumHandler : IHttpHandler
{
    public bool IsReusable { get => true; }

    public void ProcessRequest(HttpContext context)
    {
        try
        {
            var sum = 0;

            foreach (var key in context.Request.QueryString.AllKeys)
                sum += int.Parse(context.Request.QueryString.Get(key));

            context.Response.Write(sum.ToString());
        }
        catch
        {
            context.Response.Write("Ошибка");
        }
    }
}