public class Program
{
    public static void Main()
    {
        //criando classes anonimas (classe sem definiçao inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17
        };
        var pessoa2 = new {
            nome = "Maria",
            email = "maria@aluno.senai.br"
        };

        Console.WriteLine($"A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($"A pessoa2 é {pessoa2.nome} e o seu email é {pessoa2.email}");

        //pessoa1.nome = "Douglas";

        var carro1 = new {
            marca = "Honda",
            modelo = "City",
            cor = "preto",
            ano = 2023

        };
        var carro2 = new {
            marca = "Honda",
            modelo = "HRV",
            cor = "Branco",
            ano = 2020

        };
        Console.WriteLine($"O carro1 é {carro1.marca} do modelo {carro1.modelo} da cor {carro1.cor} do ano {carro1.ano}");
        Console.WriteLine($"O carro1 é {carro2.marca} do modelo {carro2.modelo} da cor {carro2.cor} do ano {carro2.ano}");
    }
}