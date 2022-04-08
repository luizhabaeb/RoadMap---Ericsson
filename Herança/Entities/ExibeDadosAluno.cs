using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entities
{
    internal class ExibeDadosAluno
    {
        public string Nome { get; set; }

        public ExibeDadosAluno()
        {
        }

        public ExibeDadosAluno(string nome)
        {
            Nome = nome;
        }

        public virtual string ExibeNome()
        {
            return "Aluno(a) "
            + Nome
            + " está matriculado(a).";
        }
}
