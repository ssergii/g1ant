using System;

namespace g1ant
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new HashUtils();

            Console.WriteLine(String.Format("hash: {0}, decod: {1}", 25157672851591, t.Decode(25157672851591, 8)));
            Console.WriteLine(String.Format("hash: {0}, decod: {1}", 25157672851591, t.Decode(25157672851591)));
        }
    }
}