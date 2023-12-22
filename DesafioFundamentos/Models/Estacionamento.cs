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
        {   //adiciona carro ao estacionamento
            
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa.ToUpper());
            Console.WriteLine("Carro adicionado");
            
        }

        public void RemoverVeiculo()
        {   // verifica se existe carro no estacionamento e o remove o carro selecionado
            if(veiculos.Any())
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
            
                string placa = "";
                placa = Console.ReadLine();


                
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    
                    int horas = int.Parse(Console.ReadLine());
                    decimal valorTotal = valorTotal = precoInicial + (precoPorHora * horas) ; 

                
                    veiculos.Remove(placa);

                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                    

                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            else
            {
                
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void ListarVeiculos()
        {   // lista os carros no estacionamento
            
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach(string veículo in veiculos){
                    
                    Console.WriteLine(veículo);
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

            
        }
    }
}
