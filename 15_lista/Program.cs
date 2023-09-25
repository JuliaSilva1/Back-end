using System.Collections.Generic;
using Sesi.Models;
public class Program
{
    public static void Main()
    {
        //criando uma lista de inteiros 
        List<int> listaNumeros = new List<int>();


        //adicionando elementos á lista    
        listaNumeros.Add(10); //posição [0]
        listaNumeros.Add(20); // posição [1]
        listaNumeros.Add(45);  //posição [2]

        //acessando os dados da lista pelo indice
        Console.WriteLine(listaNumeros[2]);

        //contagem de elementos 
        Console.WriteLine($"Nesse momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55); //posição [3]
        Console.WriteLine($"Nesse momento temos {listaNumeros.Count} elementos");


        Console.WriteLine("########################");

       List<string> listaNomes = new List<string>();

        listaNomes.Add("Julia");
        listaNomes.Add("Giovana");
        listaNomes.Add("Clara");

        Console.WriteLine(listaNomes[2]);

        Console.WriteLine($"Nesse momento temos {listaNomes.Count} elementos");


        Console.WriteLine("########################");

        //criando uma lista de numero já atribuindo valores 
        List<int> numeros = new List<int> {1, 2, 5, 6, 8, 9};
        Console.WriteLine($"Quantidade de elementos na lista números: {numeros.Count}");
        numeros.Remove(2); //remover o elemento 5
        numeros.RemoveAt(1); // remover o elemento no indice 1
        numeros.RemoveRange(2,2); //remove 2 elementos a partir do indice 2
        
        //substituindo informação do item da lista
        numeros[0] = 100;

        //iterando sobre todos os itens da lista
        foreach(int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        foreach(string item in listaNomes)
        {
            Console.WriteLine(item);
        }
          
         //Criando uma lista com objetos da classe aluno
         List<Aluno> listaAlunos = new List<Aluno>();

         //adicionando um novo aluno á minha lista 
         Aluno novoAluno = new Aluno("Pedro", 16);
         listaAlunos.Add(novoAluno);

         listaAlunos.Add(new Aluno("Patricia", 17));
         listaAlunos.Add(new Aluno("Bob", 17));

         //exibindo lista de alunos
         Console.WriteLine("Lista de alunos:");

         foreach(Aluno item in listaAlunos)
        {
            Console.WriteLine($"{item.nome} tem {item.idade} anos");
        }

        //criando uma nova lista, ordenando por nome 
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;

       foreach (var aluno in ordenacao)
       {
       Console.WriteLine(aluno.nome);
       }

       //LINQ utilizando sintaxe de método
       var consulta = listaAlunos
                           .Where(aluno => aluno.idade == 17)
                           .OrderBy(aluno => aluno.nome);
       
       foreach(var aluno in consulta)
       {
        Console.WriteLine(aluno.nome);
       }
    }
}