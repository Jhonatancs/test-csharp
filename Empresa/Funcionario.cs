using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    public class Funcionario
    {
        private string Nome;
        private int Codigo;

        public Funcionario(string nm,int cd)
        {
            this.Nome = nm;
            this.Codigo = cd;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public int getCodigo()
        {
            return this.Codigo;
        }

        public bool fazAlgo()
        {
            return true;
        }

        public int calcula(int a, int b)
        {
            return a + b;
        }
    }
}
