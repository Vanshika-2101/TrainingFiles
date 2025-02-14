
using Microsoft.EntityFrameworkCore;
using Serilog;
using SRM_86.Models;
using SRM_86.Repo;

namespace SRM_86
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers().AddNewtonsoftJson();
            builder.Services.AddCors(options => options.AddPolicy("SrmCors", policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

            builder.Services.AddDbContext<Srm86Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Conn")));
            //builder.Services.AddTransient<Srm86Context>();
            builder.Services.AddTransient<IEquities, EquitiesOps>();
            builder.Services.AddTransient<IBonds, BondOps>();
            builder.Services.AddScoped<AuditLogService>();
            builder.Services.AddScoped<ExceptionLoggingService>();

            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).Enrich.FromLogContext().WriteTo.Console().WriteTo.File("logs/MyAppLog.txt").CreateLogger();

            builder.Host.UseSerilog();


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

            app.UseMiddleware<ExceptionHandlingMiddleware>();

            app.UseCors("SrmCors");
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
