using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using GraphiQl;
using GraphQL;
using GraphQL.Types;
using GraphQL.Server;
using GraphQL.Server.Ui.Voyager;
using GraphQL.Server.Ui.GraphiQL;
using GraphQL.Server.Ui.Playground;
using ExampleData.Schema;

namespace ExampleProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // serviços
            //services.AddSingleton<ILivrosRepositorio, LivrosRepositorio>();

            // objetos
            //services.AddSingleton<LivroType>();

            // query e schema
            //services.AddSingleton<DtiQuery>();
            //services.AddSingleton<DtiSchema>();

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

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
