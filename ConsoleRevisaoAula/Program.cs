Console.WriteLine(" Digite a primeira nota");
double nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota");
double nota2 = double.Parse(Console.ReadLine());


double media = (nota1 + nota2 ) / 2;
Console.Clear();


if (media >= 7)
{
    Console.WriteLine($"Aluno Aprovado : MÉDIA; {media}");
}
else if (media >= 5)
{
    Console.WriteLine($"Aluno Recuperação: MÉDIA : {media}");
}
else
{
    Console.WriteLine($"Aluno Reprovado: MÉDIA: {media}");
}
