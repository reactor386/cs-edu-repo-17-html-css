//-
using System;
using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;


namespace LifeSpot;

public class Startup
{
    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapGet("/", async context =>
            {
                var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "index.html");
                var html = await File.ReadAllTextAsync(viewPath);
                await context.Response.WriteAsync(html);
            });

            // добавляем новый маппинг в раздел Endpoints
            //  чтобы при обращении к [<link href="../Static/css/index.css" rel="stylesheet" type="text/css">]
            //  из [index.html] браузер мог загрузить внешние стили
            // по аналогии со страницей Index настроим на нашем сервере путь до страницы со стилями,
            //  чтобы браузер знал, откуда их загружать
            endpoints.MapGet("/Static/css/index.css", async context =>
            {
                var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Static", "css", "index.css");
                var html = await File.ReadAllTextAsync(viewPath);
                await context.Response.WriteAsync(html);
            });
        });
    }
}
