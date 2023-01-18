using System.Text;

namespace ASP_lab_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", context =>
            {
                return context.Response.WriteAsync("HOME");
            });

            app.MapGet("/example1", context =>
            {
                return context.Response.WriteAsync("Ilya Mazurok");
            });

            app.MapGet("/example2", context =>
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"<div>{AppDomain.CurrentDomain.BaseDirectory}</div>");
                sb.AppendLine($"<div>{DateTime.Now.ToString()}</div>");
                context.Response.Headers.Add("Content-Type", "text/html;charset=utf-8");
                return context.Response.WriteAsync(sb.ToString());
            });

            app.MapGet("/example3", context =>
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"<ul><li>breakfast</li>");
                sb.AppendLine($"<li>homework</li>");
                sb.AppendLine($"<li>walk with the dog</li>");
                sb.AppendLine($"<li>classes at the academy</li>");
                sb.AppendLine($"<li>relaxation</li>");
                sb.AppendLine($"</ul>");
                context.Response.Headers.Add("Content-Type", "text/html;charset=utf-8");
                return context.Response.WriteAsync(sb.ToString());
            });
            app.Run();
        }
    }
}