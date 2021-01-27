using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaCambioBank.Utils
{
    public class Paths
    {
        public Paths()
        {

        }

        public static string DadosCotacao => @"C:\Users\caduf\source\repos\RotinaCambioBank\RotinaCambioBank\Planilhas\DadosCotacao.csv";

        public static string DePara => @"C:\Users\caduf\source\repos\RotinaCambioBank\RotinaCambioBank\Planilhas\DePara.csv";
        public static string DadosMoeda => @"C:\Users\caduf\source\repos\RotinaCambioBank\RotinaCambioBank\Planilhas\DadosMoeda.csv";
        public static string Resultado => $@"C:\Users\caduf\source\repos\RotinaCambioBank\RotinaCambioBank\Planilhas\Resultado_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.csv";
    }
}
