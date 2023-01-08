namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string AdicionandoPlaca = Console.ReadLine();
            
            if(veiculos.Any(x => x.ToUpper() == AdicionandoPlaca.ToUpper()))
            {
                Console.WriteLine($"Esse veiculo de Placa {AdicionandoPlaca} ja foi Adicionado.");
            }
            else
            {
                veiculos.Add(AdicionandoPlaca);
            }
        }
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string RemovendoPlaca =  Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == RemovendoPlaca.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                decimal horas = int.Parse(Console.ReadLine()); ;
                decimal valorTotal = precoInicial + (precoPorHora * horas);;
                veiculos.Remove(RemovendoPlaca);

                Console.WriteLine($"\nTaxa do estacionamento:------------------------------- R$ {precoInicial.ToString("F2")}\n" +
                                    $"Preço por Hora:--------------------------------------- R$ {precoPorHora.ToString("F2")}\n" +
                                    $"Tempo que o veiculo Permaneceu no estacionado:-------- {horas} h\n\n" +
                                    $"O veículo {RemovendoPlaca} foi removido e o preço total foi de: R$ {valorTotal.ToString("F2")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                for (int contador = 0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine(veiculos[contador]);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
