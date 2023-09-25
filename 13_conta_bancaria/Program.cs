using Models;

public class Banco
{
    public static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        conta pessoa1 = new conta(Console.ReadLine());


        string opcao = "";

        do
        {
            Console.WriteLine("######### Bem-vindo ao banco da juju #########");
            Console.WriteLine("- Exibir uma menu com as opções");
            Console.WriteLine("1 - Consultar saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3- Sacar");
            Console.WriteLine("0- Sair");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Saindo do sistema...");
                    System.Threading.Thread.Sleep(1000);
                    break;
                case "1":
                    pessoa1.Consultar();
                    break;
                case "2":
                    //Receber o valor a ser depositado com o ReadLine
                    Console.WriteLine("Qual o valor do deposito:");
                    decimal valorDep = decimal.Parse(Console.ReadLine());
                    pessoa1.Depositar(valorDep);
                    break;
                case "3":
                 Console.WriteLine("Qual o valor do seu saque:");
                    decimal valorSar = decimal.Parse(Console.ReadLine());
                    pessoa1.Sacar(valorSar);
                    break;  

                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }

        } while (opcao != "0");
    }

}