namespace Libraries.PRS
{
    /// <summary>
    /// PRS Compression
    /// </summary>
    public partial class PRS
    {
        /// <summary>
        /// Decompresses a byte array, returning the decompressed data in a new byte array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] Decompress(byte[] data)
        {
            Decompress_Context ctx = new Decompress_Context(data);

            // Get decompressed size, no more no less
            int decompressed_size = Process(ctx, true);
            // Set the destination buffer
            ctx.SetDst(decompressed_size);
            // Reset the flags and positions
            ctx.Reset();
            // Now do the thing
            Process(ctx, false);
            // Return the decompressed data
            return ctx.GetDst();
        }

        private static int Process(Decompress_Context ctx, bool size_only)
        {
            int flag = 0;
            int size = 0;
            int offset = 0;

            // Invert
            size_only = !size_only;

            while (true)
            {
                // Read the flag bit for this pass.
                flag = ctx.ReadBit();

                if (flag == 1)
                {
                    // Flag bit = 1 -> Simple byte copy from src to dst.
                    ctx.CopyByte(size_only);
                    continue;
                }

                // The flag starts with a zero, so it isn't just a simple byte copy.
                // Read the next bit to see what we have left to do.
                flag = ctx.ReadBit();

                if (flag == 0)
                {
                    // Flag bit = 0 -> short copy.

                    // Fetch the two bits needed to determine the size.
                    flag = ctx.ReadBit();
                    size = ctx.ReadBit();
                    size = (size | (flag << 1)) + 2;

                    // Fetch the offset byte.
                    offset = ctx.ReadByte();
                    offset = (int)(offset | 0xFFFFFF00);
                }
                else
                {
                    // Flag bit = 1->Either long copy or end of file.

                    offset = ctx.ReadShort();
                    if (offset == 0)
                    {
                        break;
                    }

                    // Do we need to read a size byte, or is it encoded in what we already got?
                    size = offset & 7;
                    offset >>= 3;

                    if (size == 0)
                    {
                        size = ctx.ReadByte();
                        size += 1;
                    }
                    else
                    {
                        size += 2;
                    }

                    offset = (int)(offset | 0xFFFFE000);
                }

                while (size > 0)
                {
                    ctx.CopyByteAt(size_only, offset);
                    size -= 1;
                }
            }
            return ctx.GetDstPostion();
        }
    }
    
    class Decompress_Context
    {
        private byte[] src;
        private byte[] dst;
        private int src_pos;
        private int dst_pos;

        private byte flags;
        private int bit_pos;

        internal Decompress_Context(byte[] data)
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
