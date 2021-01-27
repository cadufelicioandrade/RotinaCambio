using RotinaCambioBank.Models;
using RotinaCambioBank.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaCambioBank.Helpers
{
    public class OutPutHelpers
    {
        public OutPutHelpers()
        {

        }


        public static List<Moeda> GetDadosCotacao(List<Moeda> moedas)
        {
            
            var cotacoes = new List<Cotacao>();
            var dePara = new List<DePara>();
            var linha = String.Empty;

            using (StreamReader sr = new StreamReader(Paths.DePara))
            {
                while ((linha = sr.ReadLine()) != null)
                {
                    var dados = linha.Split(';');
                    var descricao = dados[0];
                    var codigo = Convert.ToInt32(dados[1]);

                    dePara.Add(new DePara(codigo, descricao));
                }
            }

            using (StreamReader sr = new StreamReader(Paths.DadosCotacao))
            {

                while ((linha = sr.ReadLine()) != null)
                {
                    var dados = linha.Split(';');
                    var valor = Convert.ToDecimal(dados[0]);
                    var codigo = Convert.ToInt32(dados[1]);
                    var data = Convert.ToDateTime(dados[2]);

                    cotacoes.Add(new Cotacao(valor, codigo, data));
                }
            }

            var resultado = (from m in moedas
                             join d in dePara
                                on m.Descricao equals d.Descricao
                             join c in cotacoes
                                on d.Codigo equals c.Codigo
                             where m.Data == c.Data
                             select new Moeda
                             {
                                 Data = m.Data,
                                 Valor = c.Valor,
                                 Descricao = m.Descricao
                             }).ToList();


            return resultado.ToList();
        }


        public static List<Moeda> GetDadosMoeda(DateTime dtInicio, DateTime dtFim)
        {
            var moedas = new List<Moeda>();
            var linha = String.Empty;

            using (StreamReader sr = new StreamReader(Paths.DadosMoeda))
            {
                while ((linha = sr.ReadLine()) != null)
                {

                    var dados = linha.Split(';');
                    var data = Convert.ToDateTime(dados[1]);
                    var descricao = dados[0];


                    if (data >= dtInicio && data <= dtFim)
                    {
                        moedas.Add(new Moeda(descricao, data));
                    }
                }
            }

            return moedas;
        }
    }
}
