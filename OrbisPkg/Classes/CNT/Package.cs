using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbisPkg.CNT
{
    public sealed class Package
    {
        private EndianIO IO;

        private const int ENTRY_TYPE_DIGEST_TABLE   = 0x0001;
        private const int ENTRY_TYPE_ENTRY_KEYS     = 0x0010;
        private const int ENTRY_TYPE_IMAGE_KEY      = 0x0020;
        private const int ENTRY_TYPE_GENERAL_HASHES = 0x0080;
        private const int ENTRY_TYPE_META_TABLE     = 0x0100;


        #region Constructors

        /// <summary>
        /// Initializes a new instance of the Package class on the specified file.
        /// </summary>
        /// <param name="FileName">The location of the file to load.</param>
        public Package(string FileName)
        {
            IO = new EndianIO(FileName, EndianType.BigEndian, true);
            Read();
        }

        /// <summary>
        /// Initializes a new instance of the Package class on the specified byte array.
        /// </summary>
        /// <param name="Data">The byte array to load.</param>
        public Package(byte[] Data)
        {
            IO = new EndianIO(Data, EndianType.BigEndian, true);
            Read();
        }

        /// <summary>
        /// Initializes a new instance of the Package class on the specified stream.
        /// </summary>
        /// <param name="Stream">The stream to load.</param>
        public Package(Stream Stream)
        {
            IO = new EndianIO(Stream, EndianType.BigEndian, true);
            Read();
        }

        #endregion

        private void Read()
        {

        }
    }
}
