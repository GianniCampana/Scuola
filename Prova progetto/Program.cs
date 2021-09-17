using System;

namespace Prova_progetto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 3;

            //y contiene l'indirizzo di Account
            //stack=struttura dati di tipo lifo
            //la reference y sta nello stack
            //l'oggetto accaunt è stato creato nell'area di memoria heap (mucchio, non ha un ordinamento)
            //la classe Account è il tipo
            Account y = new Account();
            Console.WriteLine(y.balance);
            Account z = y;
            F1();
            Account m = new Account(1000);
            Console.WriteLine(m.balance);
            y = new Account(); //crea un nuovo account sull heap con un altro indirizzo
            //garbage collector = distrugge l'oggetto se non è puntato a nessuna reference

            
        }
         
        static void F1()
        {
            bool magro = false;
            F2();
        }
        static void F2()
        {

        }
    }
}
