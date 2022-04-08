using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classes
{
    internal class Alunos
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public int Serie { get; set; }

        public int Nota1 { get; set; }

        public int Nota2 { get; set; }

        public int Nota3 { get; set; }

        public int NotaTotal { get; set; }


        public static string Classe;

        public Alunos()
        {

        }
        public Alunos(string nome, int idade, int serie)
        {
            Nome = nome;
            Idade = idade;
            Serie = serie;
        }

        
        public int NotaFinal()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
            NotaTotal = int.Parse(Console.ReadLine());
        }

        public int NotaFinal(int nota4)      //sobrecarga
        {
            return (NotaFinal() + nota4);
        }
        
        public void AddPonto(int addPonto)           //método
        {
            NotaTotal += addPonto + NotaFinal();
        }

                        
        public bool Aprovado()
        {
            if (NotaTotal >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

                        
        public override string ToString()
        {
            return "O aluno " + Nome + " tem " + Idade + " anos, está na " + Serie + " série e teve o seguinte desempenho: ";
        }        

    }
}




// O 'MÉTODO' é uma função dentro da classe, mas nao retorna um valor.   

//  A 'FUNÇÃO' retorna um valor no programa; é como se fosse um conjunto de cálculos ou instruções que retorna um valor no final.

// SOBRECARGA é um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porém com diferentes parâmetros.
// Por exemplo: Quero adicionar um produto ao Estoque informando a Quantidade; utilizando uma 'operação' AddProdutos()
//em outro momento quero informar a Quantidade e a Data em que foram adicionados... Eu terei mais de uma versão da operação de AddProdutos
//variando apenas a lista de parâmetros.

// ENCAPSULAMENTO consiste em esconder/proteger detalhes da implementação de um componente.
// Por exemplo, se eu tenho um Atributo "Quantidade" e não quero que o programador altere livremente
//eu seto essa propriedade como 'private' e faço com que a Quantidade só possa ser alterada por meio de uma função/método.



