Console.WriteLine("Digite o valor de x:");
int x =int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

//exemplos de operacoes aritmetica
int soma = x + y;
int subtracao = x - y;
int multiplicacao = y * x;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2;  //Calculando o resto da divisao de x/2
int restoDiv3 = y % 2;

//console para exibir na tela as variaveis em cada linha 
// soma : 15
Console.WriteLine($"soma: {soma}");
Console.WriteLine($"subtracao: {subtracao}");
Console.WriteLine($"multiplicacao: {multiplicacao}");
Console.WriteLine($"divisao: {divisao}");
Console.WriteLine($"resto: {resto}");

if (restoDiv2 == 0){
    Console.WriteLine($"O número {x} é par");
}
else {
    Console.WriteLine($"O número {x} é ímpar");
}

if (restoDiv3 == 0){
    Console.WriteLine($"O número {y} é par");
}
else {
    Console.WriteLine($"O número {y} é ímpar");
}

//Operadores ternário
// condiçao ? se verdade : senão
string resultado = (resultado == 0) ? $"O número {x} é par" : $"O número {x} é ímpar";
Console.WriteLine(resultado);

int diaSemana = 3;
//aprendendo o Switch case
switch (diaSemana){
    case 1:
    Console.WriteLine("Hoje é domíngo!");
    break;
    case 2:
     Console.WriteLine("Hoje é segunda!");
    break;
    case 3:
     Console.WriteLine("Hoje é terça!");
    break;
    case 4:
     Console.WriteLine("Hoje é quarta!");
    break;
    case 5:
     Console.WriteLine("Hoje é quinta!");
    break;
    case 6:
     Console.WriteLine("Hoje é sexta!");
    break;
    case 7:
     Console.WriteLine("Hoje é sábado!");
    break;
    default:
    Console.WriteLine("Dia invalido");
}