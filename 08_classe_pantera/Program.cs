using Models;

class Program
{
    public static void Main()
    {
        var pantera = new Pantera();

        pantera.tamanho = 60;
        pantera.peso = 90;
        pantera.cor = "preta";
        pantera.especie = "pantera negra";
        pantera.alimentacao = "lebres";
        
        pantera.Apresentar();
        pantera.correr();
        pantera.cacar();
        pantera.reproduzir();
    }
}