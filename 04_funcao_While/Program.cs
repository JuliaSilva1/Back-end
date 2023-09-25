//funcao em javaScript
//function nomeFuncao (nome)

//public static string nomeFuncao (string nome){}
class Sesi
{
    public static void Main()
    {
        //Chamando métodos sem retorno
        MostrarMensagem("Seja bem vindos");
        MostrarMensagem("Sesi/Senai");
        imprimeDataHora();
        //Chamando o metado Potenciacao com o parâmetro 4 e recebendo o retorno
        double potencia = Potenciacao(4);
        Console.WriteLine($"Potenciaçâo {potencia}");
        ContagemRegressiva(10);
        JogoQueNrSouEu();
    }

    //metado com parâmetro e com o retorno 
    public static double Potenciacao(int num)
    {
        double resultado = Math.Pow(num, 2);
        return resultado;
    }

    //Metado sem parâmetro e sem retorno
    public static void imprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToString());
    }

    //metado com parâmetro e sem retorno
    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }


    public static void ContagemRegressiva(int n)
    {
        while (n >= 0)
        {
            Console.WriteLine(n);
            n--;
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine("BOOOOOOM");

    }

    public static void JogoQueNrSouEu(){
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * ");
        Console.WriteLine("    Bem vindo ao Jogo     ");
        Console.WriteLine("Sorteei um n° de 1 a 20, tenho que adivinha-lo");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * * ");
        Console.WriteLine("");

        Random rnd = new Random();
        int nrSorteando = rnd.Next(20);
        int nrDigitando = -1;

        do{
            Console.WriteLine("Digite um n°");
            nrDigitando = int.Parse(Console.ReadLine());
            if (nrDigitando > nrSorteando)
            Console.WriteLine("O número digitado é maior que o sorteado");
            else if (nrDigitando < nrSorteando)
            Console.WriteLine("O número digitado é MENOR que o sorteado");
        }while (nrDigitando != nrSorteando);

        Console.WriteLine("Parabens você acertou!");
    }
}
