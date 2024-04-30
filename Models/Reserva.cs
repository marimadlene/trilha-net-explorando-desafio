namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int numeroDeHospede = hospedes.Count;
            int capacidadeSuite = Suite.Capacidade;

            if (capacidadeSuite >= numeroDeHospede)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte não é suficiente para o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidadeHospede = Hospedes.Count;

            return quantidadeHospede;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                decimal desconto = valor * 0.10m;
                decimal novoValor = valor - desconto;
                valor = novoValor;
            }

            return valor;
        }
    }
}