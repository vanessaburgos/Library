using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                  
            var jsonStringPath = "F:\\ProyectosSolid\\Library\\Library\\LibraryApp\\ShelfContainer\\Quijote.json";
            var jsonContent = File.ReadAllText(jsonStringPath);
            var quijote = JsonConvert.DeserializeObject<Book>(jsonContent);

            var bible = new Book("Many Authors", "La Biblia", 1800, "Vaticano");

            var bibleSerialized = JsonConvert.SerializeObject(bible);
            File.WriteAllText("F:\\ProyectosSolid\\Library\\Library\\LibraryApp\\ShelfContainer\\Bible.json", bibleSerialized);
        }
    }
}
