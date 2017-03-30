namespace Libraries.PRS
{
    /// <summary>
    /// PRS Compression
    /// </summary>
    public partial class PRS
    {
        /// <summary>
        /// Compresses a byte array, returning the compressed data in a new byte array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Compress(byte[] data)
        {
            throw new System.NotImplementedException();
        }
    }

    class Compress_Context
    {
        private byte[] src;
        private byte[] dst;
        private int src_pos;
        private int dst_pos;

        private byte flags;
        private int bit_pos;

        internal Compress_Context(byte[] data)
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

        internal int ReadBit()
        {
            int result;

            if (bit_pos == 0)
            {
                flags = src[src_pos];
                src_pos += 1;
                bit_pos = 8;
            }
            result = flags & 1;
            flags >>= 1;
            bit_pos -= 1;
            return result;
        }
        internal int ReadByte()
        {
            int result;
            result = src[src_pos];
            src_pos += 1;
            return result;
        }
        internal int ReadShort()
        {
            int result;
            result = src[src_pos] + (src[src_pos + 1] << 8);
            src_pos += 2;
            return result;
        }

        internal void CopyByte(bool copy)
        {
            if (copy)
            {
                dst[dst_pos] = src[src_pos];
            }
            src_pos += 1;
            dst_pos += 1;
        }
        internal void CopyByteAt(bool copy, int offset)
        {
            if (copy)
            {
                dst[dst_pos] = dst[dst_pos + offset];
            }
            dst_pos += 1;
        }
    }
}
