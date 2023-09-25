
namespace Models
{
    public class Pantera
    {
        public int tamanho { get; set;}
        public int peso { get; set;}
        public string cor { get; set;}
        public string especie { get; set;}
        public string alimentacao { get; set;}


        public void Apresentar()
        {
         Console.WriteLine($"Esse animal é a pantera da especie {especie}, do tamanho {tamanho} cm, com o peso de {peso} kg, com a cor {cor} e se alimenta de {alimentacao}");
        }

        public void correr(){
            Console.WriteLine($"Pantera gosta de correr");
        }
        public void cacar(){
            Console.WriteLine($"Pantera gosta de caçar");
        }
        public void reproduzir(){
            Console.WriteLine($"Pantera e facil de reproduzir");
        }
    }
}