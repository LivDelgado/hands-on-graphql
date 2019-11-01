using System.Collections.Generic;

namespace ExampleData.Models
{
    public class GuildaModel
    {
        public string Nome { get; set; }
        public IEnumerable<TriboModel> TribosParticipantes { get; set; }
    }
}
