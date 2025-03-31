using Aula156.Entities;

HashSet<Aluno> set = new HashSet<Aluno>();

Console.Write("How many students for course A? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    set.Add(new Aluno { Alunos = x });
}

Console.Write("How many students for course B? ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    set.Add(new Aluno { Alunos = x });
}

Console.Write("How many students for course C? ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    set.Add(new Aluno { Alunos = x });
}

Console.WriteLine("Total students: " + set.Count);
