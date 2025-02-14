
using Serilog;

namespace IVPLoggingAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();  //Removes default log settings i.e. both console and debug
            builder.Logging.ClearProviders();
            //builder.Logging.AddConsole();
            builder.Logging.AddDebug();

            //to implement serilog; serilog implementation code block starts
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).Enrich.FromLogContext().WriteTo.Console().WriteTo.File("logs/IVPAppLog.txt").CreateLogger();
            builder.Host.UseSerilog();
            //serilog implementation code block ends

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
