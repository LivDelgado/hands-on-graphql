using ExampleData.Models;
using ExampleData.Repositorios.Interfaces;
using GraphQL.Types;
using System.Linq;

namespace ExampleData.Schema.Types
{
    public class TriboType : ObjectGraphType<TriboModel>
    {
        public TriboType(ISquadRepositorio squadRepositorio)
        {
            Field(tribo => tribo.Nome).Description("Nome da guilda");

            Field<ListGraphType<SquadType>>(
               "squads",
               resolve: context =>
               {
                   var livros = squadRepositorio.ListarSquads().Where(squad => squad.NomeTribo == context.Source.Nome);
                   return livros;
               }
           );
        }
    }
}
