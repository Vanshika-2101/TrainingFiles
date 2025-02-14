
namespace IVP_API.MiddleWare
{
    public class IVPMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("IVP Middleware Called \n");
            await next(context);
        }
    }


}
