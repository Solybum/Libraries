namespace Libraries.PRS
{
    class HashTable
    {
        internal static int MaxWindow = 0x2000;
        internal static int WindowMask = MaxWindow - 1;
        internal static int HashSize = (1 << 8);

        internal int?[] hash;
        internal int?[] h_prev;

        internal HashTable()
        {
            hash = new int?[HashSize];
            h_prev = new int?[MaxWindow];
        }

        internal byte Hash(byte[] data, int pos)
        {
            byte h = data[pos];
            if ((pos + 1) < data.Length)
            {
                h ^= data[pos + 1];
            }
            return h;
        }

        internal int? Get(int? h)
        {
            return hash[(int)h];
        }
        internal void Set(int h, int pos)
        {
            SetPrev(pos, hash[h]);
            hash[h] = pos;
        }

        internal int? GetPrev(int? pos)
        {
            return h_prev[(int)pos & WindowMask];
        }
        internal void SetPrev(int? pos, int? prev_pos)
        {
            h_prev[(int)pos & WindowMask] = prev_pos;
        }
    }
}
