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

        private const int DEFAULT_CAPACITY = 48;
        private const int WORD_SIZE = 4;

        private int Capacity;
        private byte[] Data;

        private int Length;
        private int Count = 0;

        public Entropy(uint[] Seed, int capacity = DEFAULT_CAPACITY)
        {
            generator = new MT19937(Seed);
            Capacity = capacity;
        }

        private void AddData()
        {
            if (Count != 0)
                return;

            uint[] random = new uint[Capacity / WORD_SIZE];
            for (int i = 0; i < (Capacity / WORD_SIZE); i++) {
                uint rand = generator.genrand_int32();
                random[i] = ((rand & 0x000000ffu) << 24
                           | (rand & 0x0000ff00u) << 8 
                           | (rand & 0x00ff0000u) >> 8
                           | (rand & 0xff000000u) >> 24);
            }

            Data = new byte[random.Length * sizeof(uint)];
            Buffer.BlockCopy(random, 0, Data, 0, Data.Length);

            Length = Data.Length;
            Count = Capacity;
        }

        private byte[] SubBytes(byte[] src, int srcBegin, int srcEnd)
        {
            if (srcEnd < 0)
                srcEnd = src.Length + srcEnd;

            byte[] dst = new byte[srcEnd - srcBegin];
            Buffer.BlockCopy(src, srcBegin, dst, 0, srcEnd - srcBegin);
            return dst;
        }

        private byte[] Generate(int Size)
        {
            byte[] output = new byte[] { };

            while (Size > 0) {
                AddData();

                if (Size > Count) {
                    byte[] Slice = SubBytes(Data, (Length - Count), Length);
                    if (output.Length == 0)
                        output = Slice;
                    else
                        Buffer.BlockCopy(Slice, 0, output, output.Length, Slice.Length);

                    Size -= Count;
                    Count = 0;
                } else {
                    byte[] Slice = SubBytes(Data, (Length - Count), (Length - Count) + Size);
                    if (output.Length == 0)
                        output = Slice;
                    else
                        Buffer.BlockCopy(Slice, 0, output, output.Length, Slice.Length);

                    Count -= Size;
                    Size = 0;
                }
            }

            return output;
        }

        public byte[] CalculateEntropy(int size)
        {
            List<byte> entropy = new List<byte>();

            while (size > 0) {
                byte[] hash = SHA256.Create().ComputeHash(Generate(DEFAULT_CAPACITY));

                foreach (char c in hash) {
                    if (c != '\0') {
                        entropy.Add(Convert.ToByte(c));
                        size -= 1;
                    }
                }
            }
            
            return entropy.ToArray();
        }
    }
}