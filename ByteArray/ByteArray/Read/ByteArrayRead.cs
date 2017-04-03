using System;

namespace Libraries.ByteArray
{
    public partial class ByteArray
    {
        /// <summary>
        /// Reads a <see cref="bool"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public bool ReadBoolean()
        {
            bool result = (_buffer[_position] != 0);
            _position += 1;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="sbyte"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public sbyte ReadInt8()
        {
            sbyte result = (sbyte)_buffer[_position];
            _position += 1;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="byte"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public byte ReadUInt8()
        {
            byte result = _buffer[_position];
            _position += 1;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="short"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public short ReadInt16()
        {
            short result = (short)(_buffer[_position + 0] | _buffer[_position + 1] << 8);
            _position += 2;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="ushort"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public ushort ReadUInt16()
        {
            ushort result = (ushort)(_buffer[_position + 0] | _buffer[_position + 1] << 8);
            _position += 2;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="int"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public int ReadInt32()
        {
            int result = (_buffer[_position + 0] | _buffer[_position + 1] << 8 | _buffer[_position + 2] << 16 | _buffer[_position + 3] << 24);
            _position += 4;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="uint"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public uint ReadUInt32()
        {
            uint result = (uint)(_buffer[_position + 0] | _buffer[_position + 1] << 8 | _buffer[_position + 2] << 16 | _buffer[_position + 3] << 24);
            _position += 4;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="long"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public long ReadInt64()
        {
            uint lo = (uint)(_buffer[_position + 0] | _buffer[_position + 1] << 8 | _buffer[_position + 2] << 16 | _buffer[_position + 3] << 24);
            uint hi = (uint)(_buffer[_position + 4] | _buffer[_position + 5] << 8 | _buffer[_position + 6] << 16 | _buffer[_position + 7] << 24);
            long result = (long)((ulong)hi) << 32 | lo;
            _position += 8;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="ulong"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public ulong ReadUInt64()
        {
            uint lo = (uint)(_buffer[_position + 0] | _buffer[_position + 1] << 8 | _buffer[_position + 2] << 16 | _buffer[_position + 3] << 24);
            uint hi = (uint)(_buffer[_position + 4] | _buffer[_position + 5] << 8 | _buffer[_position + 6] << 16 | _buffer[_position + 7] << 24);
            ulong result = ((ulong)hi) << 32 | lo;
            _position += 8;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="float"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public float ReadSingle()
        {
            float result = BitConverter.ToSingle(_buffer, _position);
            _position += 4;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="double"/> advancing the internal position
        /// </summary>
        /// <returns></returns>
        public double ReadDouble()
        {
            double result = BitConverter.ToDouble(_buffer, _position);
            _position += 8;
            return result;
        }
 
        /// <summary>
        /// Reads a <see cref="bool"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public bool ReadBoolean(int position)
        {
            bool result = (_buffer[position] != 0);
            // position +=  1;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="sbyte"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public sbyte ReadInt8(int position)
        {
            sbyte result = (sbyte)_buffer[position];
            // position +=  1;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="byte"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public byte ReadUInt8(int position)
        {
            byte result = _buffer[position];
            // position +=  1;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="short"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public short ReadInt16(int position)
        {
            short result = (short)(_buffer[position + 0] | _buffer[position + 1] << 8);
            // position +=  2;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="ushort"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public ushort ReadUInt16(int position)
        {
            ushort result = (ushort)(_buffer[position + 0] | _buffer[position + 1] << 8);
            // position +=  2;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="int"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public int ReadInt32(int position)
        {
            int result = (_buffer[position + 0] | _buffer[position + 1] << 8 | _buffer[position + 2] << 16 | _buffer[position + 3] << 24);
            // position +=  4;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="uint"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public uint ReadUInt32(int position)
        {
            uint result = (uint)(_buffer[position + 0] | _buffer[position + 1] << 8 | _buffer[position + 2] << 16 | _buffer[position + 3] << 24);
            // position +=  4;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="long"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public long ReadInt64(int position)
        {
            uint lo = (uint)(_buffer[position + 0] | _buffer[position + 1] << 8 | _buffer[position + 2] << 16 | _buffer[position + 3] << 24);
            uint hi = (uint)(_buffer[position + 4] | _buffer[position + 5] << 8 | _buffer[position + 6] << 16 | _buffer[position + 7] << 24);
            long result = (long)((ulong)hi) << 32 | lo;
            // position +=  8;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="ulong"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public ulong ReadUInt64(int position)
        {
            uint lo = (uint)(_buffer[position + 0] | _buffer[position + 1] << 8 | _buffer[position + 2] << 16 | _buffer[position + 3] << 24);
            uint hi = (uint)(_buffer[position + 4] | _buffer[position + 5] << 8 | _buffer[position + 6] << 16 | _buffer[position + 7] << 24);
            ulong result = ((ulong)hi) << 32 | lo;
            // position +=  8;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="float"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public float ReadSingle(int position)
        {
            float result = BitConverter.ToSingle(_buffer, position);
            // position +=  4;
            return result;
        }
        /// <summary>
        /// Reads a <see cref="double"/> without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public double ReadDouble(int position)
        {
            double result = BitConverter.ToDouble(_buffer, position);
            // position +=  8;
            return result;
        }
    }
}
