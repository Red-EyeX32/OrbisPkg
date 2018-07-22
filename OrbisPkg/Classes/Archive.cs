using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbisPkg.Classes
{
    public class Archive
    {
        public string Folder;
        public string Name;
        public ulong Size;
        public ulong Offset;
        public uint Type;
        public string Source;

        public Archive(string _Folder, string _Name, ulong _Size, 
            ulong _Offset, uint _Type, string _Source)
        {
            Folder = _Folder;
            Name = _Name;
            Size = _Size;
            Offset = _Offset;
            Type = _Type;
            Source = _Source;
        }
    }
}