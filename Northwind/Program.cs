//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//if (!app.Environment.IsDevelopment())
//{
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.MapGet("/", () => "Hello World!");

//app.Run();

using Northwind;

Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<StartUp>();
    }).Build().Run();

Console.WriteLine("Esto se ejecuta al cerrar el servidor web");
