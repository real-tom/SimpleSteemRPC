using System;

namespace SimpleSteemRPC
{
    class Program
    {
        private static SimpleSteemRPC ssr;
        
        static void Main(string[] args)
        {
            ssr = new SimpleSteemRPC();
            Console.WriteLine("Anzahl der Konten/Number of accounts:");
            Console.WriteLine(ssr.FormatJSON(ssr.Transaction("get_account_count")));
        }
    }
}
