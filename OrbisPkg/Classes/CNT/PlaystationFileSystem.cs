using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbisPkg.CNT
{
    /// <summary>
    /// PFS (PlayStation File System) is the file system used by (at least) downloadable content and games on the PlayStation 4.
    /// It is loosely based on the UFS (Unix File System) used in FreeBSD.
    /// </summary>
    public sealed class PlaystationFileSystem
    {
        private EndianIO IO;
        public PfsFile Pfs;

        private EndianReader reader {
            get { return IO.In; }
        }

        public struct PfsFile
        {
            public PfsHeader Header;
        }

        public struct PfsHeader
        {
            public ulong Version;
            public ulong Magic;
            public uint[] Id;
            public byte Fmode;
            public byte Clean;
            public byte Ronly;
            public byte Rsv;
            public ushort Mode;
            public ushort unk;
            public uint blocksz;
            public uint nbackup;
            public ulong nblock;
            public ulong ndinode;
            public ulong ndblock;
            public ulong ndinodeblock;
            public ulong superroot_ino;
        };

        private struct di_d32 {
            public ushort mode;
            public ushort nlink;
        };

        public void Open(byte[] data)
        {
            if (data != null)
                IO = new EndianIO(data, EndianType.LittleEndian, true);
            else
                throw new Exception("[0x80000000]: Invalid PFS data detected while parsing.");

            BeginReading();
        }

        private void BeginReading()
        {
            // TODO: Parse PFS.
            Pfs.Header.Version = reader.ReadUInt64();
            Pfs.Header.Magic = reader.ReadUInt64();
        }
    }
}