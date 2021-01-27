using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaCambioBank.Models
{
    public class Cotacao
    {
        public Cotacao()
        {

        }

        public Cotacao(decimal valor, int codigo, DateTime data)
        {
            this.Valor = valor;
            this.Codigo = codigo;
            this.Data = data;
        }

        public decimal Valor { get; set; }
        public int Codigo { get; set; }
        public DateTime Data { get; set; }

    }
}
