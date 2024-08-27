using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasPOO.uteis
{
    public class Sorteador
    {
        public static List<string> SortearNomes(List<string> nomes)
        {
            Random random = new Random();
            List<string> sorteados = new List<string>();
            while(nomes.Count > 1)
            {
                int i = random.Next(0, nomes.Count);
                sorteados.Add(nomes[i]);
                nomes.Remove(nomes[i]);
            }
            sorteados.Add(nomes.First());
            return sorteados;
        }

    }
}
