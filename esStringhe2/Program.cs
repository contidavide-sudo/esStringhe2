namespace esStringhe2
{
    internal class Program
    {
        static int Trasformazione(string num)
        {
            int numeroTras = 0, cont = 0;

            for (int i = 7; i >= 0; i--)
            {
                if (num[i] == 1)
                {
                    numeroTras=numeroTras+2

                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Esercizio 1");

            string numero;

            Console.WriteLine("Inserisci il numero binario di 8 bit: ");
            numero = Console.ReadLine();

            Trasformazione(numero);

        }
    }
}
