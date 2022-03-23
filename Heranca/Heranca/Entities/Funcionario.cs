namespace Heranca.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int Hora { get; set; }
        public double ValorHoraTrabalhada { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, int hora, double valorHoraTrabalhada)
        {
            Nome = nome;
            Hora = hora;
            ValorHoraTrabalhada = valorHoraTrabalhada;
        }
        public virtual double Pagamento()
        {
            return Hora * ValorHoraTrabalhada; 
        }
    }
}
