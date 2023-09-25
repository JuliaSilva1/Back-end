class Program
{
    public static void Main()
    {
        ListadeChurrasco();
        listadeSonho();

    }

    public static void ListadeChurrasco()
    {
        string[] lista = new string[6];
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Digite o produto que vamos comprar");
            string produto = Console.ReadLine();
            lista[i] = produto;

        }
        Array.Sort(lista);
        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }

    }
    public static void listadeSonho()
    {
        string[] listaS = new string[3];
        string[] preco = new decimal[3];
        decimal total = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Digite seu sonho {i}");
            string sonho = Console.ReadLine();
            listaS[i] = sonho;

            Console.WriteLine($"Digite seu preço {i}");
            string valor =decimal.Parse(Console.ReadLine()) ;
            preco[i] = valor;
        }
        
        foreach (string item in preco)
        {
            total = total + item;  
        }
        Console.WriteLine($"Soma: {preco}");
    }

}

