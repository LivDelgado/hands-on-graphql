using ExampleData.Models;
using System.Collections.Generic;

namespace ExampleData.Repositorios.Interfaces
{
    public interface IGuildaRepositorio
    {
        List<GuildaModel> ListarGuildas();
        GuildaModel ObterGuilda(string nome);

    }
}
