using System;

namespace Libraries.ByteArray
{
    public partial class ByteArray
    {
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public bool ReadBool(int position)
        {
            bool result = (_buffer[position] != 0);
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public sbyte ReadI8(int position)
        {
            sbyte result = (sbyte)_buffer[position];
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public byte ReadU8(int position)
        {
            byte result = _buffer[position];
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public short ReadI16(int position)
        {
            short result;
            if (_endianess == Endianess.BigEndian)
            {
                result = (short)(_buffer[position + 1] | _buffer[position + 0] << 8);
            }
            else
            {
                result = (short)(_buffer[position + 0] | _buffer[position + 1] << 8);
            }
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public ushort ReadU16(int position)
        {
            ushort result;
            if (_endianess == Endianess.BigEndian)
            {
                result = (ushort)(_buffer[position + 1] | _buffer[position + 0] << 8);
            }
            else
            {
                result = (ushort)(_buffer[position + 0] | _buffer[position + 1] << 8);
            }
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public int ReadI32(int position)
        {
            int result;
            if (_endianess == Endianess.BigEndian)
            {
                result = (_buffer[position + 3] | _buffer[position + 2] << 8 | _buffer[position + 1] << 16 | _buffer[position + 0] << 24);
            }
            else
            {
                result = (_buffer[position + 0] | _buffer[position + 1] << 8 | _buffer[position + 2] << 16 | _buffer[position + 3] << 24);
            }
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public uint ReadU32(int position)
        {
            uint result;
            if (_endianess == Endianess.BigEndian)
            {
                result = (uint)(_buffer[position + 3] | _buffer[position + 2] << 8 | _buffer[position + 1] << 16 | _buffer[position + 0] << 24);
            }
            else
            {
                result = (uint)(_buffer[position + 0] | _buffer[position + 1] << 8 | _buffer[position + 2] << 16 | _buffer[position + 3] << 24);
            }
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public long ReadI64(int position)
        {
            uint lo;
            uint hi;
            if (_endianess == Endianess.BigEndian)
            {
                lo = (uint)(_buffer[position + 7] | _buffer[position + 6] << 8 | _buffer[position + 5] << 16 | _buffer[position + 4] << 24);
                hi = (uint)(_buffer[position + 3] | _buffer[position + 2] << 8 | _buffer[position + 1] << 16 | _buffer[position + 0] << 24);
            }
            else
            {
                lo = (uint)(_buffer[position + 0] | _buffer[position + 1] << 8 | _buffer[position + 2] << 16 | _buffer[position + 3] << 24);
                hi = (uint)(_buffer[position + 4] | _buffer[position + 5] << 8 | _buffer[position + 6] << 16 | _buffer[position + 7] << 24);
            }
            long result = (long)((ulong)hi) << 32 | lo;
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public ulong ReadU64(int position)
        {
            uint lo;
            uint hi;
            if (_endianess == Endianess.BigEndian)
            {
                lo = (uint)(_buffer[position + 7] | _buffer[position + 6] << 8 | _buffer[position + 5] << 16 | _buffer[position + 4] << 24);
                hi = (uint)(_buffer[position + 3] | _buffer[position + 2] << 8 | _buffer[position + 1] << 16 | _buffer[position + 0] << 24);
            }
            else
            {
                lo = (uint)(_buffer[position + 0] | _buffer[position + 1] << 8 | _buffer[position + 2] << 16 | _buffer[position + 3] << 24);
                hi = (uint)(_buffer[position + 4] | _buffer[position + 5] << 8 | _buffer[position + 6] << 16 | _buffer[position + 7] << 24);
            }
            ulong result = ((ulong)hi) << 32 | lo;
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public float ReadF32(int position)
        {
            float result;
            if (_endianess == Endianess.BigEndian)
            {
                _temp[0] = _buffer[position + 3];
                _temp[1] = _buffer[position + 2];
                _temp[2] = _buffer[position + 1];
                _temp[3] = _buffer[position + 0];
                result = BitConverter.ToSingle(_temp, 0);
            }
            else
            {
                result = BitConverter.ToSingle(_buffer, position);
            }
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public double ReadF64(int position)
        {
            double result;
            if (_endianess == Endianess.BigEndian)
            {
                _temp[0] = _buffer[position + 7];
                _temp[1] = _buffer[position + 6];
                _temp[2] = _buffer[position + 4];
                _temp[3] = _buffer[position + 4];
                _temp[4] = _buffer[position + 3];
                _temp[5] = _buffer[position + 2];
                _temp[6] = _buffer[position + 1];
                _temp[7] = _buffer[position + 0];
                result = BitConverter.ToDouble(_temp, 0);
            }
            else
            {
                result = BitConverter.ToDouble(_buffer, position);
            }
            return result;
        }
        
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public bool ReadBool()
        {
            bool result = this.ReadBool(_position);
            _position += 1;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public sbyte ReadI8()
        {
            sbyte result = this.ReadI8(_position);
            _position += 1;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public byte ReadU8()
        {
            byte result = this.ReadU8(_position);
            _position += 1;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public short ReadI16()
        {
            short result = this.ReadI16(_position);
            _position += 2;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public ushort ReadU16()
        {
            ushort result = this.ReadU16(_position);
            _position += 2;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public int ReadI32()
        {
            int result = this.ReadI32(_position);
            _position += 4;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public uint ReadU32()
        {
            uint result = this.ReadU32(_position);
            _position += 4;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public long ReadI64()
        {
            long result = this.ReadI64(_position);
            _position += 8;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public ulong ReadU64()
        {
            ulong result = this.ReadU64(_position);
            _position += 8;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public float ReadF32()
        {
            float result = this.ReadF32(_position);
            _position += 4;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public double ReadF64()
        {
            double result = this.ReadF64(_position);
            _position += 8;
            return result;
        }
    }
}
