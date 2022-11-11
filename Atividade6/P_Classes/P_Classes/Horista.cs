using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Classes
{
    class Horista : Empregado
    {
        public Double NumeroHora { get; set; }
        public Double SalarioHora { get; set; }
        public int DiasFalta { get; set; }

        public override double SalarioBruto()
        {
            return NumeroHora * SalarioHora;
        }

        public override int TempoTrabalho()
        {
            TimeSpan ts = DateTime.Today.Subtract(DataEntradaEmpresa);
            return ts.Days - DiasFalta;
        }
    }
}
