using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    internal class Aluno : ExibeDadosAluno
    {
        public string Genero { get; set; }


        public Aluno()
        {
        }

        public Aluno(string name, string genero)
            : base(name)
        {
            Genero = genero;
        }

        public override string ExibeNome()
        {
            return base.ExibeNome();
        }

    }



}
