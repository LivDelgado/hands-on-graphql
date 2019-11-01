using ExampleData.Data;
using ExampleData.Models;
using ExampleData.Repositorios.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ExampleData.Repositorios
{
    public class TriboRepositorio : ITriboRepositorio
    {
        public List<TriboModel> ListarTribos()
        {
            return TriboData.ListTribos().ToList();
        }

        public TriboModel ObterTribo(string nome)
        {
            return TriboData.ListTribos().FirstOrDefault(tribo => tribo.Nome.Contains(nome));
        }
    }
}
