public class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _logger;
    private readonly IServiceScopeFactory _serviceScopeFactory;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger, IServiceScopeFactory serviceScopeFactory)
    {
        _next = next;
        _logger = logger;
        _serviceScopeFactory = serviceScopeFactory;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            // Proceed to the next middleware
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            // Log the exception using your logging service
            _logger.LogError(ex, "An unexpected error occurred");

            // Create a scope to resolve scoped services
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var exceptionLoggingService = scope.ServiceProvider.GetRequiredService<ExceptionLoggingService>();
                // Log exception to the database or external log
                exceptionLoggingService.LogException(ex);
            }

            // Return a generic error response to the client
            httpContext.Response.StatusCode = 500; // Internal Server Error
            httpContext.Response.ContentType = "application/json";
            await httpContext.Response.WriteAsync("{\"error\": \"An unexpected error occurred. Please try again later.\"}");
        }
    }
}
