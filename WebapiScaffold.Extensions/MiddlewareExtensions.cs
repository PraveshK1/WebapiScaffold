using Microsoft.AspNetCore.Builder;
using WebapiScaffold.Middleware;

namespace WebapiScaffold.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseApiExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ApiExceptionMiddleware>();
        }
    }
}
