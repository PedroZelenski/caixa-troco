using System;

namespace caixa_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INFORME O VALOR DO(s) PRODUTO(s): ");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("INFORME A QUANTIA DE PAGAMENTO: ");
            double pagamento = Convert.ToDouble(Console.ReadLine());

            double troco = pagamento - valor;

            if (troco > 0)
                Console.WriteLine($"TROCO: {troco}");

            if (troco == 0)
                Console.WriteLine("NAO HA TROCO!");

            if (troco < 0)
                Console.WriteLine("A QUANTIA DE PAGAMENTO E INSUFICIENTE!");

        }
    }
}
