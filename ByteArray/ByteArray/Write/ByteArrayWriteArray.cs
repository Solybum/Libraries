namespace Libraries.ByteArray
{
    public partial class ByteArray
    {
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(sbyte[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                Write(array[index], position);
                position += 1;
                index++;
            }
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(byte[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                Write(array[index], position);
                position += 1;
                index++;
            }
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(short[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                Write(array[index], position);
                position += 2;
                index++;
            }
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(ushort[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                Write(array[index], position);
                position += 2;
                index++;
            }
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(int[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                Write(array[index], position);
                position += 4;
                index++;
            }
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(uint[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                Write(array[index], position);
                position += 4;
                index++;
            }
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(long[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                Write(array[index], position);
                position += 8;
                index++;
            }
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(ulong[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                Write(array[index], position);
                position += 8;
                index++;
            }
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(float[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                Write(array[index], position);
                position += 4;
                index++;
            }
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(double[] array, int index, int length, int position, Endianess endianess)
        {
            length += index;
            while (index < length)
            {
                Write(array[index], position);
                position += 8;
                index++;
            }
        }

        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(sbyte[] array, int index, int length, int position)
        {
            this.Write(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(byte[] array, int index, int length, int position)
        {
            this.Write(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(short[] array, int index, int length, int position)
        {
            this.Write(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(ushort[] array, int index, int length, int position)
        {
            this.Write(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(int[] array, int index, int length, int position)
        {
            this.Write(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(uint[] array, int index, int length, int position)
        {
            this.Write(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(long[] array, int index, int length, int position)
        {
            this.Write(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(ulong[] array, int index, int length, int position)
        {
            this.Write(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(float[] array, int index, int length, int position)
        {
            this.Write(array, index, length, position, this.endianess);
        }
        /// <summary>
        /// Write data from the array without advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="position">Position to write to</param>
        public void Write(double[] array, int index, int length, int position)
        {
            this.Write(array, index, length, position, this.endianess);
        }

        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(sbyte[] array, int index, int length, Endianess endianess)
        {
            this.Write(array, index, length, this.position, endianess);
            this.position += (length * 1);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(byte[] array, int index, int length, Endianess endianess)
        {
            this.Write(array, index, length, this.position, endianess);
            this.position += (length * 1);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(short[] array, int index, int length, Endianess endianess)
        {
            this.Write(array, index, length, this.position, endianess);
            this.position += (length * 2);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(ushort[] array, int index, int length, Endianess endianess)
        {
            this.Write(array, index, length, this.position, endianess);
            this.position += (length * 2);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(int[] array, int index, int length, Endianess endianess)
        {
            this.Write(array, index, length, this.position, endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(uint[] array, int index, int length, Endianess endianess)
        {
            this.Write(array, index, length, this.position, endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(long[] array, int index, int length, Endianess endianess)
        {
            this.Write(array, index, length, this.position, endianess);
            this.position += (length * 8);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(ulong[] array, int index, int length, Endianess endianess)
        {
            this.Write(array, index, length, this.position, endianess);
            this.position += (length * 8);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(float[] array, int index, int length, Endianess endianess)
        {
            this.Write(array, index, length, this.position, endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        /// <param name="endianess">Endianess to write with</param>
        public void Write(double[] array, int index, int length, Endianess endianess)
        {
            this.Write(array, index, length, this.position, endianess);
            this.position += (length * 8);
        }

        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(sbyte[] array, int index, int length)
        {
            this.Write(array, index, length, this.position, this.endianess);
            this.position += (length * 1);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(byte[] array, int index, int length)
        {
            this.Write(array, index, length, this.position, this.endianess);
            this.position += (length * 1);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(short[] array, int index, int length)
        {
            this.Write(array, index, length, this.position, this.endianess);
            this.position += (length * 2);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(ushort[] array, int index, int length)
        {
            this.Write(array, index, length, this.position, this.endianess);
            this.position += (length * 2);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(int[] array, int index, int length)
        {
            this.Write(array, index, length, this.position, this.endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(uint[] array, int index, int length)
        {
            this.Write(array, index, length, this.position, this.endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(long[] array, int index, int length)
        {
            this.Write(array, index, length, this.position, this.endianess);
            this.position += (length * 8);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(ulong[] array, int index, int length)
        {
            this.Write(array, index, length, this.position, this.endianess);
            this.position += (length * 8);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(float[] array, int index, int length)
        {
            this.Write(array, index, length, this.position, this.endianess);
            this.position += (length * 4);
        }
        /// <summary>
        /// Write data from the array advancing the internal position
        /// </summary>
        /// <param name="array">Array to write data from</param>
        /// <param name="index">Array position to write from</param>
        /// <param name="length">Amount of elements to write</param>
        public void Write(double[] array, int index, int length)
        {
            this.Write(array, index, length, this.position, this.endianess);
            this.position += (length * 8);
        }
    }
}
