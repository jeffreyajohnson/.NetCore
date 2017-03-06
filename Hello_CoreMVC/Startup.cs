using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
// Other using statements
using Microsoft.Extensions.Logging;
 
namespace Hello
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Add Mvc as a service making it available across our entire app
            services.AddMvc();            
        }
         
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();
            // Other middleware

            app.UseMvc();
        }
    }
}
