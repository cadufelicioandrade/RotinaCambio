using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaCambioBank.Models
{
    public class DePara
    {
        public DePara(int codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }

        public int Codigo { get; set; }
        public string Descricao { get; set; }

    }
}
