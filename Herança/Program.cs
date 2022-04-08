using Herança.Entities;

List<ExibeDadosAluno> list = new List<ExibeDadosAluno>();

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine(" Exercício de Herança - RoadMap ");
Console.ResetColor();
Console.WriteLine();

Console.Write("Quantos alunos há na sala? ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
for (int i = 1; i <= n; i++)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Aluno {i}: ");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Nome: ");
    string name = Console.ReadLine();
    Console.Write("Gênero: ");
    string genero = Console.ReadLine();
    Console.ResetColor();

    list.Add(new ExibeDadosAluno(name));
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("→ ALUNOS:");
Console.ResetColor();
foreach (ExibeDadosAluno a in list)
{
    Console.WriteLine(a.ExibeNome());
}
