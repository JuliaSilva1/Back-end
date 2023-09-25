namespace Models
{
    public class conta
    {
        private string nome { get; set; }
        private decimal nrsaldo { get; set; }
        
        public conta (string nome)
        {
            this.nome = nome;
            this.nrsaldo = 0;
        }

        public void Consultar()
        {
            Console.WriteLine($"Seu saldo é de {nrsaldo}");
        }
        public void Depositar(decimal valor)
        {
            nrsaldo = nrsaldo + valor;
            Console.WriteLine($"seu saldo é de {nrsaldo}");
        }
        public void Sacar(decimal valor)
        {
           
            Console.WriteLine($"seu saldo é de {nrsaldo}");
            if (valor > nrsaldo){
                Console.WriteLine("Seu saldo é muito baixo para sacar esse valor");
            }else {
                 nrsaldo = nrsaldo - valor;
                Console.WriteLine("Seu saque foi feito com sucesso");
            }
        }
    }
}