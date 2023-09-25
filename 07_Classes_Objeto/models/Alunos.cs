// o namespace é um nome em que usaremos pra fazer referencia quando usamos 
//em outros classes
namespace Sesi.Model
{
    //declarando nossa classe aluno
    public class Aluno
    {
        //declarando nosso atributo (propriedade) da classe
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }


        private int nrFaltas { get; set; }

        // criando um metado 
        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma}!!!");
        }

        public void AdicionarFaltas(int nr)
        {
            nrFaltas = nrFaltas + nr;
        }

        public void ResumirFaltas()
        {
            Console.WriteLine($"{nome} você tem {nrFaltas} faltas");
        }

        public void JustificarFaltas(int nr)
        {
            nrFaltas = nrFaltas - nr;
        }
    }
}