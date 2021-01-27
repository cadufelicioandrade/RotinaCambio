using RotinaCambioBank.Helpers;
using RotinaCambioBank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaCambioBank.Controllers
{
    public class RotinaController
    {
        public RotinaController()
        {
        }

        public static async Task ExecutarRotina()
        {
            var bankService = new CambioBankService();
            var fila = await bankService.GetItemFila();

            await Task.Factory.StartNew(() =>
            {
                if (fila != null)
                {
                    var moedas = OutPutHelpers.GetDadosMoeda(fila.DataInicio, fila.DataFim);
                    var resultado = OutPutHelpers.GetDadosCotacao(moedas);
                    ConvertHelpers.ToCSV(resultado);
                }
            });
        }

    }
}
