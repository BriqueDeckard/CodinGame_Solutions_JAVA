using System;
using System.Collections.Generic;
using System.Text.Json;

namespace _01_ObjectToJSON
{
    public class Departement
    {
        public int DepartementId { get; set; }

        public string DepartementName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Departement department =
                new Departement()
                { DepartementId = 667, DepartementName = "LYONZON" };

            List<string> listOfString = new List<string> { "Hello", "World" };

            List<Departement> listOfDepartment =
                new List<Departement> {
                    new Departement()
                    { DepartementId = 42, DepartementName = "IT" },
                    new Departement()
                    { DepartementId = 77, DepartementName = "Operations" }
                };

            // ---- Minified str ----
            Console.WriteLine(ConvertObjectToMinifiedJson(department));

            // ---- Formatted ----
            Console.WriteLine(ConvertObjectToFormattedJson(department));

            // ---- Convert a List ----
            Console.WriteLine(ConvertListToFormattedJson(listOfString));
            Console.WriteLine(ConvertListToFormattedJson(listOfDepartment));
        }

        private static string
        ConvertListToFormattedJson(List<Departement> list)
        {
            JsonSerializerOptions opt =
                new JsonSerializerOptions() { WriteIndented = true };
            string strJson =
                JsonSerializer.Serialize<IList<Departement>>(list, opt);
            return strJson;
        }

        private static string ConvertListToFormattedJson(List<string> list)
        {
            JsonSerializerOptions opt =
                new JsonSerializerOptions() { WriteIndented = true };
            string strJson = JsonSerializer.Serialize<IList<String>>(list, opt);
            return strJson;
        }

        private static string ConvertObjectToMinifiedJson(Departement dep)
        {
            return JsonSerializer.Serialize<Departement>(dep);
        }

        private static string ConvertObjectToFormattedJson(Departement dep)
        {
            JsonSerializerOptions opt =
                new JsonSerializerOptions() { WriteIndented = true };

            return JsonSerializer.Serialize<Departement>(dep, opt);
        }
    }
}
