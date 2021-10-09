using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Prototype.API.Web.Extensions
{
    /// <summary>
    ///     CORS (Cross-Origin Resource Sharing) is a
    ///     mechanism that gives rights to the user to
    ///     access resources from the server on a different domain.
    /// </summary>
    public static class ServiceExtensions
    {
        /// <summary>
        /// Configures the cors.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void ConfigureCors(this IServiceCollection services)
        {
            /*
             * We are using the basic settings for adding CORS policy
             * because for this project allowing any origin, method,
             * and header is quite enough. But we can be more restrictive
             * with those settings if we want. Instead of the
             * AllowAnyOrigin() method which allows requests
             * from any source, we could use the
             * WithOrigins("http://www.something.com") which will allow
             * requests just from the specified source.
             * Also, instead of AllowAnyMethod() that allows all
             * HTTP methods,  we can use WithMethods("POST", "GET")
             * that will allow only specified HTTP methods.
             * Furthermore, we can make the same changes for the
             * AllowAnyHeader() method by using, for example,
             * the WithHeaders("accept", "content-type") method to
             * allow only specified headers.
             */
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {

            });
        }
    }
}