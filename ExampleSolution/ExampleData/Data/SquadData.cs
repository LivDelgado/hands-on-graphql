using ExampleData.Models;
using System.Collections.Generic;

namespace ExampleData.Data
{
    public class SquadData
    {
        public static SquadModel Squad1 = new SquadModel { NomeTribo = "Ursos", Nome = "Polar", NumeroIntegrantes = 3 };
        public static SquadModel Squad2 = new SquadModel { NomeTribo = "Ursos", Nome = "Pardo", NumeroIntegrantes = 2 };
        public static SquadModel Squad3 = new SquadModel { NomeTribo = "Ursos", Nome = "Panda", NumeroIntegrantes = 4 };
        public static SquadModel Squad4 = new SquadModel { NomeTribo = "Ursos", Nome = "Malaio", NumeroIntegrantes = 3 };

        public static SquadModel Squad5 = new SquadModel { NomeTribo = "Hogwarts", Nome = "Corvinal", NumeroIntegrantes = 5 };
        public static SquadModel Squad6 = new SquadModel { NomeTribo = "Hogwarts", Nome = "Sonserina", NumeroIntegrantes = 3 };
        public static SquadModel Squad7 = new SquadModel { NomeTribo = "Hogwarts", Nome = "Lufa-Lufa", NumeroIntegrantes = 4 };
        public static SquadModel Squad8 = new SquadModel { NomeTribo = "Hogwarts", Nome = "Grifinória", NumeroIntegrantes = 4 };

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
