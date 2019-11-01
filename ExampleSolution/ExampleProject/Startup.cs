using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using GraphiQl;
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Voyager;
using GraphQL.Server.Ui.Playground;
using ExampleData.Schema;
using ExampleData.Repositorios.Interfaces;
using ExampleData.Repositorios;
using ExampleData.Schema.Types;

namespace ExampleProject
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // serviços
            services.AddSingleton<ITriboRepositorio, TriboRepositorio>();
            services.AddSingleton<IGuildaRepositorio, GuildaRepositorio>();
            services.AddSingleton<ISquadRepositorio, SquadRepositorio>();

            // objetos
            services.AddSingleton<TriboType>();
            services.AddSingleton<GuildaType>();
            services.AddSingleton<SquadType>();

            // query e schema
            services.AddSingleton<DtiQuery>();
            services.AddSingleton<DtiSchema>();


            services.AddSingleton<IDependencyResolver>(
                x => new FuncDependencyResolver(
                    type => x.GetRequiredService(type)
                )
            );

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
            })
            .AddWebSockets()
            .AddDataLoader();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseWebSockets();
            app.UseGraphQLWebSockets<DtiSchema>("/graphql");
            app.UseGraphQL<DtiSchema>("/graphql");


            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions()
            {
                Path = "/playground"
            });
            app.UseGraphQLVoyager(new GraphQLVoyagerOptions()
            {
                GraphQLEndPoint = "/graphql",
                Path = "/voyager"
            });

        }
    }
}
