using Projeto_Hospedagem.Models;

public class Program
{
    public static void Main(string[] args)
    {
        List<Pessoa> hospedes = new List<Pessoa>();
        Pessoa p1 = new Pessoa("João");
        Pessoa p2 = new Pessoa("Maria");

        hospedes.Add(p1);
        hospedes.Add(p2);

        Suite suite = new Suite(tipoSuite: "Luxo", precoDiaria: 500.00m, capacidade: 1);

        Reserva reserva = new Reserva(diasReservados: 12);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor total da diária: {reserva.CalcularValorDiaria()}");

    }   
}