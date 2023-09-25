// Somente declarando uma variavel  do tipo inteira e sem valor 
//int num1;

//Declarando uma variavel do tipo inteira e atribuindo valor 5
//int num2 = 5;

//declarando variavel string
//string nomeAluno = "Paulo";

// variavel do tipo logica (true ou false)
//bool resultado = true;

//variavel do tipo double valor com varias casas decimais
//double coordenada = 1.80365986;

//variaveldo tipo decimal - utilizadas para valores
//decimal valor = 1.0423;

int idade = 16;
string meuNome = "Julia";  
Console.WriteLine($"Meu nome é {meuNome} e tenho {idade} anos");
Console.WriteLine("");
Console.WriteLine("Em qual cidade você nasceu");
//readLine serve apenas para que eu receba uma informação de usuario 
//e armazeno em uma variavel
string nomeCidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {nomeCidade}");