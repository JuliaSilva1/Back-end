Console.WriteLine("Digite o nome do aluno");
string nome = Console.ReadLine();
Console.WriteLine("Digite o valor da nota 1:");
int nota1 =int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da nota 2:");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de nota 3:");
int nota3 =int.Parse(Console.ReadLine());

int soma = nota1 + nota2 + nota3;
int divisao = soma/ 3;

Console.WriteLine($"soma: {soma}");
Console.WriteLine($"divisao: {divisao}");

if (divisao >= 7){
    Console.WriteLine($"O Aluno {nome} foi APROVADO com a nota {divisao}");
}
else {
    Console.WriteLine($"O aluno {nome} não passou com a nota {divisao}");
}