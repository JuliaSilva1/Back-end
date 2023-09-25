//classse pai que sera herdado prelo filho - SuperClasse
class animal
{
    public string cor {get; set; }
    
    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som" );
    }
}

//classe filha que herdarará da classe Animal
//receberá todos os atributos e metados da SurperClasse
class Cachorro : animal
{
    public void Latir()
    {
        Console.WriteLine($"O cachorro {cor} está latindo");
    }
}

class Gato : animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"O gato está miando");
    }
}

class Program
{
    public static void Main( )
    {
        animal animalGenerico = new animal();
        animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "Caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}