// See https://aka.ms/new-console-template for more information

namespace ValorEmprestimo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual o valor do emprestimo? ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantas parcelas? ");
            int parcelas = int.Parse(Console.ReadLine());

            double valorAPagar = (valor + (valor * 20) / 100);
            Console.WriteLine("O valor a pagar é {0}", valorAPagar);

            double emprestimo = (valorAPagar / parcelas);
            Console.WriteLine("Vou pagar {0} de {1}", parcelas, emprestimo);
        }
    }
}
