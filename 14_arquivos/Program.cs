using System.IO;

public class Program
{
    public static  string caminhoArquivo = "arquivo/arquivo.txt";
  public static void Main()
  {
    chamarArquivo();
    LerArquivo();
  }

  public static void LerArquivo()
  {
   
    try
    {
        
        //verificar se o arquivo existe 
        if(File.Exists(caminhoArquivo) == false)
        {
            //criando o meu arquivo.txt, este comando é executado quando 
            //a verificação no if é falsa ou seja o arquivo não existe 
           File.Create(caminhoArquivo);
        }
    //instanciando um objeto da classe StreamReader para ler o arquivo
    using (StreamReader arquivo = new StreamReader(caminhoArquivo))
    {
        string linha;
        while((linha = arquivo.ReadLine()) != null)
        {
            Console.WriteLine(linha);
        }
    }
    }
    catch (Exception erro)
    {
        Console.WriteLine($"Ocorreu um erro ao ler o arquivo: {erro.Message}");
    }
  }

  public static void chamarArquivo()
  {
    try
    {
      using (StreamWriter arquivo = new StreamWriter(caminhoArquivo, true))
      {
        Console.WriteLine("Digite uma frase");
        arquivo.WriteLine(Console.ReadLine());
      }
    }
    catch(Exception erro)
    {
        Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
    }
  }
}