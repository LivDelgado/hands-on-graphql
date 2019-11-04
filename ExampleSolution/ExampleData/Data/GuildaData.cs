using ExampleData.Models;
using System.Collections.Generic;

namespace ExampleData.Data
{
    public class GuildaData
    {
        public static GuildaModel Guilda1 = new GuildaModel { Nome = "Games" };
        public static GuildaModel Guilda2 = new GuildaModel { Nome = "Design" };
        public static GuildaModel Guilda3 = new GuildaModel { Nome = "Música" };

        public static IEnumerable<GuildaModel> ListGuildas()
        {
            return new List<GuildaModel> { Guilda1, Guilda2, Guilda3 };
        }
    }
}
