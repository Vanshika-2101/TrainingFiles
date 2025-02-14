
using BankAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<SecurityDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SecurityConn")));

            builder.Services.AddCors(options => options.AddPolicy("IVPPolicy", builder =>
            {
                builder.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod();
            }));

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

            app.UseCors("IVPPolicy");

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
