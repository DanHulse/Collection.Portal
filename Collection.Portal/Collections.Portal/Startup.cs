using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Collections.Portal.Infrastructure;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using Collections.Portal.Services.Interfaces;
using Collections.Portal.Services;
using Microsoft.Extensions.Options;

namespace Collections.Portal
{
    /// <summary>
    /// Startup class
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Gets or sets the app configuration.
        /// </summary>
        private IConfigurationRoot Configuration { get; set; }

        /// <summary>
        /// Gets or sets the auto mapper configuration.
        /// </summary>
        private MapperConfiguration MapperConfiguration { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="env">The environment</param>
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            this.MapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfileConfiguration());
            });

            this.Configuration = builder.Build();
        }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services collection</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddMvc();

            services.Configure<AppSettings>(this.Configuration.GetSection("AppSettings"));

            services.AddSingleton(x => this.MapperConfiguration.CreateMapper());

            services.AddTransient<IRestSharpService, RestSharpService>();
            services.AddTransient<ICollectionService, CollectionService>();

            services.AddScoped(x => x.GetService<IOptionsSnapshot<AppSettings>>().Value);
        }

        /// <summary>
        /// Configures the specified application.
        /// </summary>
        /// <param name="app">The application builder interface.</param>
        /// <param name="env">The environment.</param>
        /// <param name="loggerFactory">The logger factory.</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(config =>
            {
                config.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "App", action = "Index" });
            });
        }
    }
}
