using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using NooBIT.DataTables.Queries;
using NooBIT.DataTables.Sample.Domain;
using NooBIT.DataTables.Sample.Model;

namespace NooBIT.DataTables.Sample
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.Configure<RouteOptions>(options => options.LowercaseUrls = true);
            services.AddTransient<IQueryableRequestService<SampleData>, SampleDataQueryableRequestService>();
            services.AddTransient<IDataTable<SampleData>, SampleDataTable>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();            
            app.UseMvcWithDefaultRoute();
        }
    }
}