using ExampleData.Data;
using ExampleData.Models;
using ExampleData.Repositorios.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ExampleData.Repositorios
{
    public class SquadRepositorio : ISquadRepositorio
    {
        public List<SquadModel> ListarSquads()
        {
            return SquadData.ListSquads().ToList();
        }

        public SquadModel ObterSquad(string nome)
        {
            return SquadData.ListSquads().FirstOrDefault(squad => squad.Nome.Contains(nome));
        }

        public SquadModel ObterSquad(int codigo)
        {
            return SquadData.ListSquads().FirstOrDefault(squad => squad.Codigo == codigo);
        }
    }
}
