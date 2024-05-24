
namespace Switch
{
    internal class Oppgave2
    {
        static public void Run()
        {
            Console.WriteLine("Skriv ett tall fra 1-7");

            var input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    Console.WriteLine("Mandag");
                    break;
                case "2":
                    Console.WriteLine("Tirsdag");
                    break;
                case "3":
                    Console.WriteLine("Onsdag");
                    break;
                case "4":
                    Console.WriteLine("Torsdag");
                    break;
                case "5":
                    Console.WriteLine("Fredag");
                    break;
                case "6":
                    Console.WriteLine("Lørdag");
                    break;
                case "7":
                    Console.WriteLine("Søndag");
                    break;
                default:
                    Console.WriteLine("Ingenting");
                    break;
            }
        }
    }
}
