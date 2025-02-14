

using IVP_API.MiddleWare;

namespace IVP_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

      

            // Add services to the container.

            builder.Services.AddControllers();
            //builder.Services.AddTransient<IVPMiddleWare>(); //different objects
            //builder.Services.AddScoped<IVPMiddleWare>(); //sharable object in same session
            //builder.Services.AddSingleton<IVPMiddleWare>(); //single object for everyone using 

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Use Method Called \n");
            //    await next();
            //    await context.Response.WriteAsync("Use Method Ended \n");
            //});

            //app.Map("/Nikhil", CustomCode);
            //app.UseMiddleware<IVPMiddleWare>();

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("New Use Method Called \n");
            //    await next();
            //    await context.Response.WriteAsync("New Use Method Ended \n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Run method called \n");
            //});

            //app.Run(async context =>
            //{
            //    await context.Response.WriteAsync("Run method not called");     //This will not get executed.
            //});

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

        //private static void CustomCode(IApplicationBuilder app)
        //{
        //    app.Use(async (context, next) =>
        //    {
        //        await context.Response.WriteAsync("Map Use Method Called \n");
        //        await next();
        //        await context.Response.WriteAsync("Map Use Method Ended \n");
        //    });
        //}
    }
}
