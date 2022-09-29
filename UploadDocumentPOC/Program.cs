
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using TradingViewUdfProvider;
using UploadDocumentPOCWebAPI;

using Microsoft.Extensions.Logging.EventLog;

using static Helper.SimpleWorkerService;
using Helper;
using System.ServiceProcess;
using System.Diagnostics;
using UploadDocumentPOCWebAPI.Entities;

var builder = WebApplication.CreateBuilder(args);
string connString = builder.Configuration.GetConnectionString("EntitiesConnection");

builder.Services.AddDbContext<DataLayer.Entities.YahooFinanceContext>(options =>
{
    options.UseSqlServer(connString);
});
// Add services to the container.


builder.Services.AddCors(options => options.AddDefaultPolicy(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

//builder.Services.AddControllers();
builder.Services.AddControllers()
           .AddJsonOptions(opts =>
           {
               opts.JsonSerializerOptions.IgnoreNullValues = true;
           });
//builder.Host.UseWindowsService();
//builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.DIScopes();
//builder.Services.Configure<EventLogSettings>(config =>
//    {
//        config.LogName = String.Empty;
//        config.SourceName = "WindowsService";
//});

var app = builder.Build();

app.UseCors();
//app.UseCors("ClientPermission");
app.UseRouting();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.DefaultModelsExpandDepth(-1);
    });

}

//    IHost host = Host.CreateDefaultBuilder(args)
//    .ConfigureLogging(options =>
//    {
//        if (OperatingSystem.IsWindows())
//        {
//            options.AddFilter<EventLogLoggerProvider>(level => level >= LogLevel.Information);
//        }
//    })
//    .ConfigureServices(services =>
//    {
//        services.AddHostedService<Worker>();

//        if (OperatingSystem.IsWindows())
//        {
//            services.Configure<EventLogSettings>(config =>
//            {
//                if (OperatingSystem.IsWindows())
//                {
//                    config.LogName = "Sample Service";
//                    config.SourceName = "Sample Service Source";
//                }
//            });
//        }
//    })
//    .UseWindowsService()
//    .Build();

//host.Run();


app.UseStaticFiles();
app.UseTradingViewProvider(new TradingViewSettings());

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();


