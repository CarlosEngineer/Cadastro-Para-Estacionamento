namespace DesafioFundamentos.Models
{
    public class Estacionamento 
    {
        private decimal precoInicial = 0m;
        private decimal precoPorHora = 0m;
        
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:\n");
            //convertendo tudo para string 
            string placa = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o nome do cliente:");
            string Cliente = Convert.ToString(Console.ReadLine());
            //adicionando a placa para lista de veiculos
            veiculos.Add(placa);
        
            if(string.IsNullOrEmpty(Cliente) && 
               string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("Digite o nome e a placa do cliente");
            }
            Console.WriteLine($"Confirmado, o Sr(a){Cliente} o seu carro de placa: {placa} esta registrado");

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            string placa = Convert.ToString(Console.ReadLine());

            

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
             
                decimal valorTotal = 0; 

                int horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = (precoPorHora * horas) + precoInicial;
                Console.WriteLine($"O valor total a pagar pelas {horas} horas de permanencia com um adicional de {precoInicial.ToString("C2")} e de: {valorTotal.ToString("C2")}");

                // TODO: Remover a placa digitada da lista de veículos
           
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal.ToString("C2")}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
               
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"veiculo de placa: {veiculo}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
