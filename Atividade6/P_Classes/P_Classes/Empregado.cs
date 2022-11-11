using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Classes
{
    abstract class Empregado
    { // Atributos
        private int matricula;
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;

        //Propriedades
        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }
        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        //Metodos
        public abstract double SalarioBruto();
        public virtual int TempoTrabalho()
        {
            TimeSpan ts = DateTime.Today.Subtract(DataEntradaEmpresa);
            return ts.Days;
        }
    }
}
