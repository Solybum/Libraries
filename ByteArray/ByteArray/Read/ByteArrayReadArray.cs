namespace Libraries.ByteArray
{
    public partial class ByteArray
    {
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(sbyte[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadI8(position, endianess);
                position += 1;
                index++;
            }
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(byte[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadU8(position, endianess);
                position += 1;
                index++;
            }
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(short[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadI16(position, endianess);
                position += 2;
                index++;
            }
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(ushort[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadU16(position, endianess);
                position += 2;
                index++;
            }
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(int[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadI32(position, endianess);
                position += 4;
                index++;
            }
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(uint[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadU32(position, endianess);
                position += 4;
                index++;
            }
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(long[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadI64(position, endianess);
                position += 8;
                index++;
            }
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(ulong[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadU64(position, endianess);
                position += 8;
                index++;
            }
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(float[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadF32(position, endianess);
                position += 4;
                index++;
            }
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(double[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadF64(position, endianess);
                position += 8;
                index++;
            }
        }

        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(sbyte[] array, int index, int length, int position)
        {
            this.Read(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(byte[] array, int index, int length, int position)
        {
            this.Read(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(short[] array, int index, int length, int position)
        {
            this.Read(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(ushort[] array, int index, int length, int position)
        {
            this.Read(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(int[] array, int index, int length, int position)
        {
            this.Read(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(uint[] array, int index, int length, int position)
        {
            this.Read(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(long[] array, int index, int length, int position)
        {
            this.Read(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(ulong[] array, int index, int length, int position)
        {
            this.Read(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(float[] array, int index, int length, int position)
        {
            this.Read(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Read data to the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="position">Position to read from</param>
        public void Read(double[] array, int index, int length, int position)
        {
            this.Read(array, index, length, position, this.endianess);
        }

        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(sbyte[] array, int index, int length, Endianess endianess)
        {
            this.Read(array, index, length, this.position, endianess);
            this.position += (length * 1);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(byte[] array, int index, int length, Endianess endianess)
        {
            this.Read(array, index, length, this.position, endianess);
            this.position += (length * 1);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(short[] array, int index, int length, Endianess endianess)
        {
            this.Read(array, index, length, this.position, endianess);
            this.position += (length * 2);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(ushort[] array, int index, int length, Endianess endianess)
        {
            this.Read(array, index, length, this.position, endianess);
            this.position += (length * 2);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(int[] array, int index, int length, Endianess endianess)
        {
            this.Read(array, index, length, this.position, endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(uint[] array, int index, int length, Endianess endianess)
        {
            this.Read(array, index, length, this.position, endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(long[] array, int index, int length, Endianess endianess)
        {
            this.Read(array, index, length, this.position, endianess);
            this.position += (length * 8);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(ulong[] array, int index, int length, Endianess endianess)
        {
            this.Read(array, index, length, this.position, endianess);
            this.position += (length * 8);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(float[] array, int index, int length, Endianess endianess)
        {
            this.Read(array, index, length, this.position, endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        /// <param name="endianess">Endianess to read with</param>
        public void Read(double[] array, int index, int length, Endianess endianess)
        {
            this.Read(array, index, length, this.position, endianess);
            this.position += (length * 8);
        }

        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(sbyte[] array, int index, int length)
        {
            this.Read(array, index, length, this.position, this.endianess);
            this.position += (length * 1);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(byte[] array, int index, int length)
        {
            this.Read(array, index, length, this.position, this.endianess);
            this.position += (length * 1);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(short[] array, int index, int length)
        {
            this.Read(array, index, length, this.position, this.endianess);
            this.position += (length * 2);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(ushort[] array, int index, int length)
        {
            this.Read(array, index, length, this.position, this.endianess);
            this.position += (length * 2);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(int[] array, int index, int length)
        {
            this.Read(array, index, length, this.position, this.endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(uint[] array, int index, int length)
        {
            this.Read(array, index, length, this.position, this.endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(long[] array, int index, int length)
        {
            this.Read(array, index, length, this.position, this.endianess);
            this.position += (length * 8);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(ulong[] array, int index, int length)
        {
            this.Read(array, index, length, this.position, this.endianess);
            this.position += (length * 8);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(float[] array, int index, int length)
        {
            this.Read(array, index, length, this.position, this.endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Read data to the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to read data to</param>
        /// <param name="index">Array position to read to</param>
        /// <param name="length">Amount of elements to read</param>
        public void Read(double[] array, int index, int length)
        {
            this.Read(array, index, length, this.position, this.endianess);
            this.position += (length * 8);
        }
    }
}
