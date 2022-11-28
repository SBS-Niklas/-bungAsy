namespace ÜbungAsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AsyncMethodAuslesen().Result);
            AsyncMethodEingabe();
            AsyncMethodEingabe();
            Console.WriteLine(AsyncMethodAuslesen().Result);

            Console.ReadKey();

        }

        static async Task<string> AsyncMethodAuslesen()
        {
            return await File.ReadAllTextAsync("File1.txt");
        }

        static  void AsyncMethodEingabe()
        {
           
             File.AppendAllTextAsync("File1.txt", "Ich wurde eingefügt im Programm!!");
        }
    }

        
}