using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OrbisPkg.Security;
using System.Security.Cryptography;
using System.Globalization;

namespace OrbisPkg.Classes
{
    public class Entropy
    {
        private MT19937 generator;

        private const uint DEFAULT_CAPACITY = 48;
        private const uint WORD_SIZE = 4;

        private uint Capacity;
        private byte[] Buffer;

        private uint Size;
        private uint Count = 0;

        public Entropy(uint[] Seed, uint capacity = DEFAULT_CAPACITY)
        {
            generator = new MT19937(Seed);
            Capacity = capacity;
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        public void FillBuffer()
        {
            string Random = "";

            if (Count != 0)
                return;

            for (int i = 0; i < (Capacity / WORD_SIZE); i++) {
                Random += string.Format("{0}", generator.Next().ToString("X8"));
            }

            Buffer = StringToByteArray(Random);

            Size = (uint)Buffer.Length;
            Count = Capacity;
        }

        public string Slice(string source, int start, int end)
        {
            if (end < 0) // Keep this for negative end support
                end = source.Length + end;

            int len = end - start;               // Calculate length
            return source.Substring(start, len); // Return Substring of length
        }

        public string Generate(int size)
        {
            string output = "";

            while (size > 0) {
                FillBuffer();

                if (size > Count) {
                    output += Slice(Encoding.ASCII.GetString(Buffer), (int)(Size - Count), (int)Size);

                    size -= (int)Count;
                    Count = 0;
                } else {
                    output += Slice(Encoding.ASCII.GetString(Buffer), (int)(Size - Count), (int)(Size - Count) + size);

                    Count -= (uint)size;
                    size = 0;
                }
            }

            return output;
        }

        public string GenerateSecure(int size)
        {
            string output = "";

            while (size > 0) {
                byte[] Data = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(Generate((int)DEFAULT_CAPACITY)));

                foreach (char c in Data) {
                    if (c != '\0') {
                        output += c;
                        size -= 1;
                    }
                }
            }

            return output;
        }
    }
}