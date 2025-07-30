namespace Projeto_Hospedagem.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public Suite(string tipoSuite, decimal precoDiaria, int capacidade)
        {
            TipoSuite = tipoSuite;
            ValorDiaria = precoDiaria;
            Capacidade = capacidade;
        }
    }
}