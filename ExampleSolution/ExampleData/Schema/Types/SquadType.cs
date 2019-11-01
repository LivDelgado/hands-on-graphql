using ExampleData.Models;
using GraphQL.Types;

namespace ExampleData.Schema.Types
{
    public class SquadType : ObjectGraphType<SquadModel>
    {
        public SquadType()
        {
            Field(squad => squad.Nome).Description("Nome do squad");
            Field(squad => squad.NomeTribo).Description("Nome da tribo da qual o squad faz parte");
            Field(squad => squad.NumeroIntegrantes).Description("Número de crafters que atualmente compõem o squad");
        }
    }
}
