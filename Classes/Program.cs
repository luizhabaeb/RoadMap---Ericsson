using Classes;


Alunos a = new Alunos("Luiz", 15, 3);
Console.WriteLine(a);

Console.WriteLine("Digite as 3 notas que obteve: ");
a.Nota1 = int.Parse(Console.ReadLine());
a.Nota2 = int.Parse(Console.ReadLine());
a.Nota3 = int.Parse(Console.ReadLine());

Console.WriteLine("Sua nota final foi: " + a.NotaFinal());
Console.WriteLine();

Console.WriteLine("Insira seu ponto extra: ");
int addPonto = int.Parse(Console.ReadLine());
a.AddPonto(addPonto);
Console.WriteLine();
Console.WriteLine("Nota atualizada: " + a.NotaTotal);

if (a.Aprovado())
{
    Console.WriteLine("APROVADO! Nota final → " + a.NotaTotal);
}
else
{
    Console.WriteLine("REPROVADO");
 
}

Console.WriteLine();

