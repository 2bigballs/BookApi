using BookApi.Middlewares;
using Microsoft.AspNetCore.SpaServices.AngularCli;

namespace BookApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddPresentation(builder.Configuration);
            
            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            if (app.Environment.IsDevelopment())
            {
                app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            }
            app.UseGlobalHandler();

            app.UseStaticFiles();

            app.UseLoggingRequest();

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseSpaStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "api/{controller}/{action}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "C:\\Users\\illya\\OneDrive\\??????? ????\\Programming\\Front\\Angular\\library";
                if (app.Environment.IsDevelopment())
                {

                    spa.UseAngularCliServer(npmScript: "start");
                    spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
                }
            });

            app.MapControllers();

            app.Run();
        }
    }
}