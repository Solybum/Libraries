namespace Libraries.ByteArray
{
    public partial class ByteArray
    {
        /// <summary>
        /// Writes data from array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to write to</param>
        public void Write(sbyte[] array, int index, int length, int position)
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
        /// Writes data from array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to write to</param>
        public void Write(byte[] array, int index, int length, int position)
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
        /// Writes data from array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to write to</param>
        public void Write(short[] array, int index, int length, int position)
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
        /// Writes data from array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to write to</param>
        public void Write(ushort[] array, int index, int length, int position)
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
        /// Writes data from array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to write to</param>
        public void Write(int[] array, int index, int length, int position)
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
        /// Writes data from array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to write to</param>
        public void Write(uint[] array, int index, int length, int position)
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
        /// Writes data from array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to write to</param>
        public void Write(long[] array, int index, int length, int position)
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
        /// Writes data from array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to write to</param>
        public void Write(ulong[] array, int index, int length, int position)
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
        /// Writes data from array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to write to</param>
        public void Write(float[] array, int index, int length, int position)
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
        /// Writes data from array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to write to</param>
        public void Write(double[] array, int index, int length, int position)
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
        /// Writes data from array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Write(sbyte[] array, int index, int length)
        {
            this.Write(array, index, length, this._position);
            this._position += (length * 1);
        }
        /// <summary>
        /// Writes data from array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Write(byte[] array, int index, int length)
        {
            this.Write(array, index, length, this._position);
            this._position += (length * 1);
        }
        /// <summary>
        /// Writes data from array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Write(short[] array, int index, int length)
        {
            this.Write(array, index, length, this._position);
            this._position += (length * 2);
        }
        /// <summary>
        /// Writes data from array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Write(ushort[] array, int index, int length)
        {
            this.Write(array, index, length, this._position);
            this._position += (length * 2);
        }
        /// <summary>
        /// Writes data from array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Write(int[] array, int index, int length)
        {
            this.Write(array, index, length, this._position);
            this._position += (length * 4);
        }
        /// <summary>
        /// Writes data from array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Write(uint[] array, int index, int length)
        {
            this.Write(array, index, length, this._position);
            this._position += (length * 4);
        }
        /// <summary>
        /// Writes data from array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Write(long[] array, int index, int length)
        {
            this.Write(array, index, length, this._position);
            this._position += (length * 8);
        }
        /// <summary>
        /// Writes data from array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Write(ulong[] array, int index, int length)
        {
            this.Write(array, index, length, this._position);
            this._position += (length * 8);
        }
        /// <summary>
        /// Writes data from array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Write(float[] array, int index, int length)
        {
            this.Write(array, index, length, this._position);
            this._position += (length * 4);
        }
        /// <summary>
        /// Writes data from array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Write(double[] array, int index, int length)
        {
            this.Write(array, index, length, this._position);
            this._position += (length * 8);
        }
    }
}
