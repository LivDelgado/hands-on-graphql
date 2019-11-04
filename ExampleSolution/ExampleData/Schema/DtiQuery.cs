using ExampleData.Repositorios.Interfaces;
using ExampleData.Schema.Types;
using GraphQL.Types;

namespace ExampleData.Schema
{
    public class DtiQuery : ObjectGraphType
    {
        public DtiQuery(ISquadRepositorio squadRepositorio, IGuildaRepositorio guildaRepositorio, ITriboRepositorio triboRepositorio)
        {
            Name = "Query";
            Field<ListGraphType<SquadType>>(
              "squads",
              resolve: context =>
              {
                  return squadRepositorio.ListarSquads();
              }
            );

            Field<ListGraphType<TriboType>>(
              "tribos",
              resolve: context =>
              {
                  return triboRepositorio.ListarTribos();
              }
            );

            Field<SquadType>(
              "squad",
              arguments: new QueryArguments(
                    new QueryArgument<StringGraphType> { Name = "nome", Description = "Nome do squad a pesquisar" }
              ),
              resolve: context =>
              {
                  var nome = context.GetArgument<string>("nome");
                  return squadRepositorio.ObterSquad(nome);
              }
            );

            Field<TriboType>(
                "tribo",
              arguments: new QueryArguments(
                    new QueryArgument<StringGraphType> { Name = "nome", Description = "Nome da tribo a pesquisar" }
              ),
              resolve: context =>
              {
                  var nome = context.GetArgument<string>("nome");
                  return triboRepositorio.ObterTribo(nome);
              }
            );
        }
    }
}
