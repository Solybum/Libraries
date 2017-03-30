using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.PRS
{
    class Context
    {
        internal byte[] src;
        internal byte[] dst;
        internal int src_pos;
        internal int dst_pos;
        
        internal byte flags;
        internal int flag_pos;
        internal int bit_pos;

        internal Context(byte[] data)
        {
            src = data;
            dst = null;
            src_pos = 0;
            dst_pos = 0;

            flags = 0;
            bit_pos = 0;
        }
        internal void Reset()
        {
            src_pos = 0;
            dst_pos = 0;

            flags = 0;
            bit_pos = 0;
        }

        internal void SetDst(int length)
        {
            dst = new byte[length];
        }
        internal byte[] GetDst()
        {
            return dst;
        }
        internal int GetDstPostion()
        {
            return dst_pos;
        }
    }
}
