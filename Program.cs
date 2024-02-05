using System.Text;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        //"/"相当于网址
        app.MapGet("/", () =>
        {
            //return html
            // return Results.Text("<h1>hello World <h1>", "text/html");
            // ==
            byte[] data = Encoding.UTF8.GetBytes("<h1>hello World <h1>");
            return Results.Text(data, "text/html");
        });
        
        app.MapGet("/hello", () => "yo");





        //运行
        app.Run();
    }
}


