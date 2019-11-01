using ExampleData.Models;
using System.Collections.Generic;

namespace ExampleData.Repositorios.Interfaces
{
    public interface ISquadRepositorio
    {
        List<SquadModel> ListarSquads();
        SquadModel ObterSquad(string nome);

    }
}
