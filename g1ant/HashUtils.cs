using System;
using System.Linq;
using System.Text;

namespace g1ant
{
    /// <summary>
    /// Decode an 8-letter word from the chain of signs “acegilmnoprstuwxyz”, where the outcome of the function GetHash() is equal to “25157672851591”.
    /// As an example, if you want to find a 4-letter word, where the outcome of the function GetHash() = 13625924, the outcome of the task is the word “rano”.
    /// </summary>
    class HashUtils
    {
        private static string _signs = "acegilmnoprstuwxyz";

        public long GetHash(string s)
        {
            long h = 7;
            for (int i = 0; i < s.Length; i++)
                h = h * 37 +
                   "acegilmnoprstuwxyz".IndexOf(s[i]);
            return h;
        }

        /// <summary>
        /// Decode the hashing word
        /// </summary>
        /// <param name="value">The hash value to decode.</param>
        /// <param name="length">Hashing word length.</param>
        /// <returns>Decoding word.</returns>
        public string Decode(long value, int length)
        {
            var sb = new StringBuilder();
            long index = 0;

            for (int i = 1; i <= length; i++)
            {
                if (value <= 7)
                {
                    if (i < length)
                        throw new Exception(
                            string.Format("Decoded word '{0}' contains only {1} signs out of {2}", new string(sb.ToString().Reverse().ToArray()), i, length));
                    else
                        break;
                }

                index = value % 37;
                value = (value - index) / 37;

                char c = _signs[(int)index];
                sb.Append(c);
            }

            return new string(sb.ToString().Reverse().ToArray());
        }

        /// <summary>
        /// Decode the hashing word
        /// </summary>
        /// <param name="value">The hash value to decode.</param>
        /// <returns>Decoding word.</returns>
        public string Decode(long value)
        {
            var sb = new StringBuilder();
            long index = 0;

            for (long h = value; h > 7; )
            {
                index = h % 37;
                h = (h - index) / 37;

                char c = _signs[(int)index];
                sb.Append(c);
            }

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
}
