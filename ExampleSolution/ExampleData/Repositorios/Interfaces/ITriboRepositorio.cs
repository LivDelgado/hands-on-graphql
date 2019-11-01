using ExampleData.Models;
using System.Collections.Generic;

namespace ExampleData.Repositorios.Interfaces
{
    public interface ITriboRepositorio
    {
        List<TriboModel> ListarTribos();
        TriboModel ObterTribo(string nome);
    }
}
