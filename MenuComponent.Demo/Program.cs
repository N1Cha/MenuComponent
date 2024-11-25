using MenuComponent.Demo.Components;
using MenuComponent.Demo.Services;

namespace MenuComponent.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorComponents().AddInteractiveServerComponents();
            builder.Services.AddSingleton<IDataService,InMemoryDataService>();

            var app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
