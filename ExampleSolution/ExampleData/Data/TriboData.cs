using ExampleData.Models;
using System.Collections.Generic;

namespace ExampleData.Data
{
    public class TriboData
    {
        public static TriboModel Tribo1 = new TriboModel { Nome = "Ursos" };

        public static TriboModel Tribo2 = new TriboModel { Nome = "Hogwarts" };

        public static IEnumerable<TriboModel> ListTribos()
        {
            return new List<TriboModel> { Tribo1, Tribo2 };
        }
    }
}
