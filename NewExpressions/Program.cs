using System;

namespace NewExpressions
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Formas convêncionais
            Carro carro = new Carro("Honda", "WR-V", "AAA-1234", 79921);
            var carro1 = new Carro("Honda", "WR-V", "AAA-1234", 79921);

            // Nova possibilidade
            Carro carro2 = new ("Honda", "WR-V", "AAA-1234", 79921);

            Console.WriteLine("Carros:");
            Console.WriteLine(carro.ToString());
            Console.WriteLine(carro1.ToString());
            Console.WriteLine(carro2.ToString());
        }
    }

    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public decimal Valor { get; set; }

        public Carro(string marca, string modelo, string placa, decimal valor)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Valor = valor;
        }

        public override string ToString() =>
            $"Marca: {Marca} | Modelo: {Modelo} | Placa: {Placa} | Valor: {Valor:C}";
    }
}
