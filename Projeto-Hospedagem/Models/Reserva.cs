namespace Projeto_Hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }


        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("Quantidade de hóspedes excede a capacidade da suíte.");
            }
            Hospedes = hospedes;
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        public decimal CalcularValorDiaria()
        {
            if (DiasReservados >= 10)
            {
                decimal cal = Suite.ValorDiaria * DiasReservados;
                return cal - (cal * 0.1m);
            }
            return Suite.ValorDiaria * DiasReservados;
        }
    }
}