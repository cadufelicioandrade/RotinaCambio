using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinaCambioBank.Models
{
    public class Fila
    {
        public Fila()
        {

        }

        public int Id { get; set; }
        public string Moeda { get; set; }
        public bool EstaNaFila { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
    }
}
