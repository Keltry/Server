namespace lab6
{
    class Program 
        {
        static void Main(string[] args)
        {
            // Задание  6.3
            //  Ввести целое число. Разложить его на простые множители. Например, число 234 это 2*3*3*13.

            int numeric = int.Parse(Console.ReadLine());
            Console.Write( "Число " + numeric + " - это ");

            int nMin = 0;
            int nMax = numeric;

            do
            {
                nMin ++ ;

                if ( nMax % nMin == 0 )
                    Console.Write(nMin + "*");

            } while (nMin < nMax);



        }
    }
}
