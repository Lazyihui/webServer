using System.Text;


public static class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        //"/"相当于网址
        app.MapGet("/", () => {
            //return html
            // return Results.Text("<h1>hello World <h1>", "text/html");
            // ==
            // 文件是字节流
            byte[] data = Encoding.UTF8.GetBytes("<h1>hello World <h1>");
            return Results.Text(data, "text/html");

        });
        //客服端请求文件
        // download
        //http://localhost:5218/dl 下载文件
        app.MapGet("/dl", () => {
            byte[] data = File.ReadAllBytes("c.zip");
            return Results.File(data, "application/zip", "c.zip");
        });

        app.MapGet("/hello", () => "yo");





        //运行
        app.Run();
    }
}


