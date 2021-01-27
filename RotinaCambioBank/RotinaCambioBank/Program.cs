using RotinaCambioBank.Controllers;
using RotinaCambioBank.Helpers;
using RotinaCambioBank.Models;
using RotinaCambioBank.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RotinaCambioBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcao = 0;
            var inicio = new DateTime();
            var fim = new DateTime();

            Console.WriteLine("\n****************** Rotina Cambio ******************\n\n");

            Console.WriteLine("##### Hora Início #####");
            Console.WriteLine("#     (1) - 09:00     #");
            Console.WriteLine("#     (2) - 09:30     #");
            Console.WriteLine("#######################\n");

            do
            {
                Console.Write("Selecione a opção do horário de início da rotina: ");
                opcao = Convert.ToInt32(Console.ReadLine());

            } while (opcao != 1 && opcao != 2);

            if (opcao == 1)
            {
                inicio = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 09:00:00"));
            }
            else if (opcao == 2)
            {
                inicio = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 09:30:00"));
            }

            opcao = 0;

            Console.WriteLine("\n##### Hora Fim #####");
            Console.WriteLine("#   (1) - 18:00    #");
            Console.WriteLine("#   (2) - 18:30    #");
            Console.WriteLine("####################\n");

            do
            {
                Console.Write("Selecione a opção do horário de fim da rotina: ");
                opcao = Convert.ToInt32(Console.ReadLine());

            } while (opcao != 1 && opcao != 2);


            if (opcao == 1)
            {
                fim = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 18:00:00"));
            }
            else if (opcao == 2)
            {
                fim = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 18:30:00"));
            }


            Console.WriteLine("\nIniciando Câmbio. . .\n");
            var horarioInicio = DateTime.Now.TimeOfDay;

            while (DateTime.Now >= inicio && DateTime.Now <= fim)
            {
                StartProcess();

                Console.WriteLine("Próximo Fluxo em 2 minutos\n");
                Thread.Sleep(TimeSpan.FromMinutes(2));
            }

            GetFullTime(horarioInicio);

            Console.ReadKey();
        }

        public static async void StartProcess()
        {
            await Task.WhenAll(RotinaController.ExecutarRotina());
        }
        
        public static void GetFullTime(TimeSpan time)
        {
            var horarioFim = (DateTime.Now.TimeOfDay - time).ToString();
            Console.WriteLine($"Tempo total processamento: {horarioFim.Substring(0, horarioFim.IndexOf('.'))}");
        }

    }
}
