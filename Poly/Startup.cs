using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Poly
{
    internal class Startup
    {
        public Startup(IHostingEnvironment env)
        { }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.Run(async (context) =>
            {
                Class.Car carInstance = new Class.Car("start","stop","speed","direction");
                await context.Response.WriteAsync(carInstance.Start());
            });
        }
    }
}