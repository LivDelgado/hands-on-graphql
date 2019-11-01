using System.Collections.Generic;

namespace ExampleData.Models
{
    public class TriboModel
    {
        public string Nome { get; set; }
        public IEnumerable<SquadModel> Squads { get; set; }
    }
}
