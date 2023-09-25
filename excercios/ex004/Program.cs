class sesi
{
    public static void Main()
    {
        Console.WriteLine("Digite um numero: ");
        int dobro = int.Parse(Console.ReadLine());
        int valor = Dobro(dobro);
        Console.WriteLine($"Dobro {valor}");
        int valorDigitado = int.Parse(Console.ReadLine());
        int metade = Metade(valorDigitado);
        Console.WriteLine($"Metade {metade}");

        Console.WriteLine("Digite um nr para calcular a tabuada");
        CarregarTabuado(int.Parse(Console.ReadLine()));
        Soma();

    }

    public static int Dobro(int num)
    {
        int resultado = (num * 2);
        return resultado;
    }
    public static int Metade(int num)
    {
        int resultado = (num / 2);
        return resultado;
    }
    public static void CarregarTabuado(int n)
    {
        int contador = 1;
        while (contador <= 10)
        {
            Console.WriteLine($"{n} X {contador} = {n * contador}");
            contador++;
        }

    }

    public static void Soma()
    {
        int soma = 0;
        int menor = 1000;
        int maior = 0;
        int num = 0;
        do
        {
            Console.WriteLine("Digite um número:");
            num = int.Parse(Console.ReadLine());

            if (num > maior)
                maior = num;
            if(num < menor && num > 0)
                menor = num;

            soma = soma + num;
        } while(num > 0 );
    
        Console.WriteLine($"O número maior é {maior} o menor é {menor} e soma é {soma}");

    }
}