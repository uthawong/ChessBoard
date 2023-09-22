namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej hej!\nVälkommen till schackbrädet!\nAnge en siffra.");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            
            for (int row = 1; row <= number; row++) // Yttre for loop är raden.
                                                    // Kolumnen är på den nuvarande raden och är därför nästlad.
            {
               

                for (int column = 1; column <= number; column++) // inre for loop går över till nästa rad (yttre loopen) bara efter att alla kolumner har skrivits ut på den nuvarande raden.
                {
                    if ((row + column) %2 == 0) // if villkorssats är antingen sant eller falskt.
                                                // Modulus är en rest av en division mellan två tal.
                                                // Rad och kolumn adderas och modulus kollar om en division i 2 ger en rest.


                    {
                        Console.Write("0"); // Console.Write används för att skriva ut data utan att skriva ut en ny rad.
                                            // Det gick inte att använda Console.OutputEncoding = System.Text.Encoding.Unicode; och svarta / vita rutor för mig.

                    }
                    else
                    {
                        Console.Write("I");
                    }
                   
                }
                Console.WriteLine(); // Console.WriteLine används för att skriva ut data och skriva ut en ny rad.
            }
            

        }
    }
}