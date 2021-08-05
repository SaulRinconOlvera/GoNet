using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNet
{
    class Program
    {
        private static List<Estructura> _estructura;

        static void Main() {
            PopulateEstructura();
            var result = GetMando("Noemi");
            Console.WriteLine(result);
        }

        private static string GetMando(string name)
        {
            var parentId = _estructura.Where(e => e.Name == name)
                .Select(e => e.ParentId).FirstOrDefault();
            if(parentId is null) return "";

            var parentName = _estructura.Where(e => e.Id == parentId)
                .Select(e => e.Name).FirstOrDefault();
            var result = $"{parentName},{GetMando(parentName)}";
            return result;
        }

        private static void PopulateEstructura()
        {
            _estructura  =  new List<Estructura> {
                new Estructura(1, "Jose", null),
                new Estructura(2, "Marco", 1),
                new Estructura(3, "Pedro", 1),
                new Estructura(4, "Araceli", 2),
                new Estructura(5, "Antonio", 2),
                new Estructura(6, "Andrea", 2),
                new Estructura(7, "Abigail", 4),
                new Estructura(8, "Noemi", 4),
                new Estructura(9, "Josue", 3),
                new Estructura(10, "Adriana", 3),
                new Estructura(11, "Victor", 9),
                new Estructura(12, "Mónica", 9),
            };
        }
    }

    class Estructura {

        public Estructura(int id, string name, int? parentId)
        {
            Id = id; Name = name; ParentId = parentId;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int? ParentId { get; private set; }
    }    
}
