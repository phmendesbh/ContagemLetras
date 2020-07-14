using System;
using System.Collections.Generic;
using System.Linq;

namespace ContagemLetras
{
    class Program
    {


        static void Main(string[] args)
        {
            IDictionary <string, int> alfabeto = new Dictionary<string, int>();

            var nomesUtilizados = new List<string>() {
                "Eloiza",
                "Dulcilene",
                "Carlos",
                "Alda",
                "Alineia",
                "Welington",
                "Karine",
                "June",
                "Cleide",
                "Sabrina",
                "Ines",
                "Mercia",
                "Mirete",
                "Idalmo",
                "Ricardo",
                "Maria",
                "Savana",
                "Eloa",
                "Miguel",
                "Gabriel",
                "Thais",
                "Sergina",
                "Vanessa",
                "Cecilia",
                "Familia",
                "Lucas",
                "Betinha",
                "Newton",
                "Lais",
                "Paulo",
                "Stella",
                "Maria",
                "Olivia",
                "Miguel",
                "Claudia",
                "Julia",
                "Milla"
            };

            nomesUtilizados.ForEach(palavra => {
                var letras = palavra.ToUpper().ToCharArray();
                foreach (var letra in letras)
                {
                    if (alfabeto.ContainsKey(letra.ToString())) {
                        alfabeto[letra.ToString()] = alfabeto[letra.ToString()] + 1;
                    } else {
                        alfabeto.Add(letra.ToString(),1);
                    }
                }
            });

            foreach (var letraUsada in new SortedDictionary<string, int>(alfabeto))
            {                
                Console.WriteLine("Letra {0} -> {1}", letraUsada.Key, letraUsada.Value);
            }

        }
    }
}
