using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaCambioBank.Models
{
    public class Moeda
    {
        public Moeda()
        {

        }

        public Moeda(string descricao, DateTime data)
        {
            this.Descricao = descricao;
            this.Data = data;
        }

        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public Decimal Valor { get; set; }

    }
}
