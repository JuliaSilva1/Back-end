class Program
{
    public static string[] poltronas = new string[43];

    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo no SesiBus");
        Console.WriteLine("---------------------");
        Console.WriteLine("Contamos com 42 lugares disponiveis");

        Menu();

    }

    public static void Menu()
    {

        string opcao = "";

        do
        {
            Console.WriteLine("######### MENU #########");
            Console.WriteLine("1 - Para comprar passagem");
            Console.WriteLine("2 - Para poltronas disponivieis");
            Console.WriteLine("0- Para fechar o sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado, volte sempre!!!");
                    System.Threading.Thread.Sleep(1000); // espera de 1s
                    break;
                case "1":
                    ComprarPasssagem();
                    break;
                case "2":
                     PoltronaDisponivel();
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }

        } while (opcao != "0");
    }

    public static void ComprarPasssagem()
    {
        Console.WriteLine("Quantas passagem deseja comprar?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagens; i++){
            Console.WriteLine($"Digite a poltrona da {i}ª passagem:");
            int nrPassagens = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome){
        poltronas[nrPoltrona] = nome;
    }

    public static void PoltronaDisponivel(){
        Console.WriteLine("Lista de poltronas disponiveis");
        for (int i = 1; i <= 42; i++){
            if (poltronas[i] == null){
                Console.WriteLine($"N° {i}");
            }
        }
    }
}