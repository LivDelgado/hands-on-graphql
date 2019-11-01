using ExampleData.Models;
using System.Collections.Generic;

namespace ExampleData.Data
{
    public class SquadData
    {
        public static SquadModel Squad1 = new SquadModel { Codigo = 1, Nome = "Polar", NumeroIntegrantes = 3 };
        public static SquadModel Squad2 = new SquadModel { Codigo = 2, Nome = "Pardo", NumeroIntegrantes = 2 };
        public static SquadModel Squad3 = new SquadModel { Codigo = 3, Nome = "Panda", NumeroIntegrantes = 4 };
        public static SquadModel Squad4 = new SquadModel { Codigo = 4, Nome = "Malaio", NumeroIntegrantes = 3 };

        public static SquadModel Squad5 = new SquadModel { Codigo = 5, Nome = "Corvinal", NumeroIntegrantes = 5 };
        public static SquadModel Squad6 = new SquadModel { Codigo = 6, Nome = "Sonserina", NumeroIntegrantes = 3 };
        public static SquadModel Squad7 = new SquadModel { Codigo = 7, Nome = "Lufa-Lufa", NumeroIntegrantes = 4 };
        public static SquadModel Squad8 = new SquadModel { Codigo = 8, Nome = "Grifinória", NumeroIntegrantes = 4 };

        public static List<SquadModel> Squads = new List<SquadModel>
        {
            Squad1, Squad2, Squad3, Squad4, Squad5, Squad6, Squad7, Squad8
        };

        public static IEnumerable<SquadModel> ListSquads()
        {
            return Squads;
        }
    }
}
