using System;

namespace g1ant
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new HashUtils();

            try
            {
                Console.WriteLine(String.Format("hash: {0}, decoded word: {1}", 25157672851591, t.Decode(25157672851591, 8)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(String.Format("hash: {0}, decoded word: {1}", 25157672851591, t.Decode(25157672851591)));
        }
    }
}