using ApiBusinessLogic.Implementation.Encuesta;
using ApiBusinessLogic.Implementation.Master;
using ApiBusinessLogic.Implementation.Periodo;
using ApiBusinessLogic.Implementation.Poblacion;
using ApiBusinessLogic.Implementation.Resultado;
using ApiBusinessLogic.Implementation.TipoEncuesta;
using ApiBusinessLogic.Implementation.Usuario;
using ApiBusinessLogic.Interfaces.Encuesta;
using ApiBusinessLogic.Interfaces.Master;
using ApiBusinessLogic.Interfaces.Periodo;
using ApiBusinessLogic.Interfaces.Poblacion;
using ApiBusinessLogic.Interfaces.Resultado;
using ApiBusinessLogic.Interfaces.TipoEncuesta;
using ApiBusinessLogic.Interfaces.Usuario;
using ApiDataAccess.General;
using ApiUnitOfWork.General;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ESAMicroservicesApi;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddScoped<IPoblacionLogic, PoblacionLogic>();
        services.AddScoped<ITipoEncuestaLogic, TipoEncuestaLogic>();
        services.AddScoped<IPeriodoLogic, PeriodoLogic>();
        services.AddScoped<IEncuestaLogic, EncuestaLogic>();
        services.AddScoped<IMasterLogic, MasterLogic>();
        services.AddScoped<IResultadoLogic, ResultadoLogic>();
        services.AddScoped<IUsuarioLogic, UsuarioLogic>();

        services.AddSingleton<IUnitOfWork>(option => new UnitOfWork(
                    Configuration.GetConnectionString("develop-azure")
                ));

        services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Welcome to running ASP.NET Core on AWS Lambda");
            });
        });
    }
}