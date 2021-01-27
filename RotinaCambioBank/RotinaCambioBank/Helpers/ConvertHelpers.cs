using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using RotinaCambioBank.Models;
using RotinaCambioBank.Utils;

namespace RotinaCambioBank.Helpers
{
    public class ConvertHelpers
    {
        public ConvertHelpers()
        {

        }

        public static void ToCSV(List<Moeda> resultado)
        {
            using (var stream = new FileStream(Paths.Resultado, FileMode.Create))
            {
                using (var sw = new StreamWriter(stream))
                {
                    for (int i = 0; i < resultado.Count; i++)
                    {
                        sw.Write($"{resultado[i].Descricao};{resultado[i].Data.ToString()};{resultado[i].Valor.ToString()}{Environment.NewLine}");
                    }
                }
            }
        }


    }
}
