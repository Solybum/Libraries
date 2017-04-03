using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries.ByteArray
{
    public partial class ByteArray
    {
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to read from</param>
        public void Read(sbyte[] array, int index, int length, int position)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadI8(position);
                position += 1;
                index++;
            }
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to read from</param>
        public void Read(byte[] array, int index, int length, int position)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadU8(position);
                position += 1;
                index++;
            }
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to read from</param>
        public void Read(short[] array, int index, int length, int position)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadI16(position);
                position += 2;
                index++;
            }
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to read from</param>
        public void Read(ushort[] array, int index, int length, int position)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadU16(position);
                position += 2;
                index++;
            }
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to read from</param>
        public void Read(int[] array, int index, int length, int position)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadI32(position);
                position += 4;
                index++;
            }
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to read from</param>
        public void Read(uint[] array, int index, int length, int position)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadU32(position);
                position += 4;
                index++;
            }
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to read from</param>
        public void Read(long[] array, int index, int length, int position)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadI64(position);
                position += 8;
                index++;
            }
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to read from</param>
        public void Read(ulong[] array, int index, int length, int position)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadU64(position);
                position += 8;
                index++;
            }
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to read from</param>
        public void Read(float[] array, int index, int length, int position)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadF32(position);
                position += 4;
                index++;
            }
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        /// <param name="position">ByteArray index to read from</param>
        public void Read(double[] array, int index, int length, int position)
        {
            length += index;
            while (index < length)
            {
                array[index] = ReadF64(position);
                position += 8;
                index++;
            }
        }
        
        /// <summary>
        /// Reads data into the array, advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Read(sbyte[] array, int index, int length)
        {
            this.Read(array, index, length, _position);
            _position += (length * 1);
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Read(byte[] array, int index, int length)
        {
            this.Read(array, index, length, _position);
            _position += (length * 1);
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Read(short[] array, int index, int length)
        {
            this.Read(array, index, length, _position);
            _position += (length * 2);
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Read(ushort[] array, int index, int length)
        {
            this.Read(array, index, length, _position);
            _position += (length * 2);
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Read(int[] array, int index, int length)
        {
            this.Read(array, index, length, _position);
            _position += (length * 4);
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Read(uint[] array, int index, int length)
        {
            this.Read(array, index, length, _position);
            _position += (length * 4);
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Read(long[] array, int index, int length)
        {
            this.Read(array, index, length, _position);
            _position += (length * 8);
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Read(ulong[] array, int index, int length)
        {
            this.Read(array, index, length, _position);
            _position += (length * 8);
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Read(float[] array, int index, int length)
        {
            this.Read(array, index, length, _position);
            _position += (length * 4);
        }
        /// <summary>
        /// Reads data into the array, without advancing the internal position
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index">Starting position in the array</param>
        /// <param name="length">Amount of array values to read</param>
        public void Read(double[] array, int index, int length)
        {
            this.Read(array, index, length, _position);
            _position += (length * 8);
        }
    }
}
