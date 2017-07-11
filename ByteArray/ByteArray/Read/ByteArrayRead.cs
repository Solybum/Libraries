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
            bool result = (this._buffer[position] != 0);
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public sbyte ReadI8(int position)
        {
            sbyte result = (sbyte)this._buffer[position];
            return result;
        }
        /// <summary>
        /// Reads data without advancing the internal position
        /// </summary>
        /// <param name="position">ByteArray index to read from</param>
        /// <returns></returns>
        public byte ReadU8(int position)
        {
            byte result = this._buffer[position];
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
            if (this._endianess == Endianess.BigEndian)
            {
                result = (short)(this._buffer[position + 1] | this._buffer[position + 0] << 8);
            }
            else
            {
                result = (short)(this._buffer[position + 0] | this._buffer[position + 1] << 8);
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
            if (this._endianess == Endianess.BigEndian)
            {
                result = (ushort)(this._buffer[position + 1] | this._buffer[position + 0] << 8);
            }
            else
            {
                result = (ushort)(this._buffer[position + 0] | this._buffer[position + 1] << 8);
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
            if (this._endianess == Endianess.BigEndian)
            {
                result = (this._buffer[position + 3] | this._buffer[position + 2] << 8 | this._buffer[position + 1] << 16 | this._buffer[position + 0] << 24);
            }
            else
            {
                result = (this._buffer[position + 0] | this._buffer[position + 1] << 8 | this._buffer[position + 2] << 16 | this._buffer[position + 3] << 24);
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
            if (this._endianess == Endianess.BigEndian)
            {
                result = (uint)(this._buffer[position + 3] | this._buffer[position + 2] << 8 | this._buffer[position + 1] << 16 | this._buffer[position + 0] << 24);
            }
            else
            {
                result = (uint)(this._buffer[position + 0] | this._buffer[position + 1] << 8 | this._buffer[position + 2] << 16 | this._buffer[position + 3] << 24);
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
            if (this._endianess == Endianess.BigEndian)
            {
                lo = (uint)(this._buffer[position + 7] | this._buffer[position + 6] << 8 | this._buffer[position + 5] << 16 | this._buffer[position + 4] << 24);
                hi = (uint)(this._buffer[position + 3] | this._buffer[position + 2] << 8 | this._buffer[position + 1] << 16 | this._buffer[position + 0] << 24);
            }
            else
            {
                lo = (uint)(this._buffer[position + 0] | this._buffer[position + 1] << 8 | this._buffer[position + 2] << 16 | this._buffer[position + 3] << 24);
                hi = (uint)(this._buffer[position + 4] | this._buffer[position + 5] << 8 | this._buffer[position + 6] << 16 | this._buffer[position + 7] << 24);
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
            if (this._endianess == Endianess.BigEndian)
            {
                lo = (uint)(this._buffer[position + 7] | this._buffer[position + 6] << 8 | this._buffer[position + 5] << 16 | this._buffer[position + 4] << 24);
                hi = (uint)(this._buffer[position + 3] | this._buffer[position + 2] << 8 | this._buffer[position + 1] << 16 | this._buffer[position + 0] << 24);
            }
            else
            {
                lo = (uint)(this._buffer[position + 0] | this._buffer[position + 1] << 8 | this._buffer[position + 2] << 16 | this._buffer[position + 3] << 24);
                hi = (uint)(this._buffer[position + 4] | this._buffer[position + 5] << 8 | this._buffer[position + 6] << 16 | this._buffer[position + 7] << 24);
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
            if (this._endianess == Endianess.BigEndian)
            {
                this._temp[0] = this._buffer[position + 3];
                this._temp[1] = this._buffer[position + 2];
                this._temp[2] = this._buffer[position + 1];
                this._temp[3] = this._buffer[position + 0];
                result = BitConverter.ToSingle(this._temp, 0);
            }
            else
            {
                result = BitConverter.ToSingle(this._buffer, position);
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
            if (this._endianess == Endianess.BigEndian)
            {
                this._temp[0] = this._buffer[position + 7];
                this._temp[1] = this._buffer[position + 6];
                this._temp[2] = this._buffer[position + 5];
                this._temp[3] = this._buffer[position + 4];
                this._temp[4] = this._buffer[position + 3];
                this._temp[5] = this._buffer[position + 2];
                this._temp[6] = this._buffer[position + 1];
                this._temp[7] = this._buffer[position + 0];
                result = BitConverter.ToDouble(this._temp, 0);
            }
            else
            {
                result = BitConverter.ToDouble(this._buffer, position);
            }
            return result;
        }
        
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public bool ReadBool()
        {
            bool result = this.ReadBool(this._position);
            this._position += 1;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public sbyte ReadI8()
        {
            sbyte result = this.ReadI8(this._position);
            this._position += 1;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public byte ReadU8()
        {
            byte result = this.ReadU8(this._position);
            this._position += 1;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public short ReadI16()
        {
            short result = this.ReadI16(this._position);
            this._position += 2;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public ushort ReadU16()
        {
            ushort result = this.ReadU16(this._position);
            this._position += 2;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public int ReadI32()
        {
            int result = this.ReadI32(this._position);
            this._position += 4;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public uint ReadU32()
        {
            uint result = this.ReadU32(this._position);
            this._position += 4;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public long ReadI64()
        {
            long result = this.ReadI64(this._position);
            this._position += 8;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public ulong ReadU64()
        {
            ulong result = this.ReadU64(this._position);
            this._position += 8;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public float ReadF32()
        {
            float result = this.ReadF32(this._position);
            this._position += 4;
            return result;
        }
        /// <summary>
        /// Reads data advancing the internal position
        /// </summary>
        /// <returns></returns>
        public double ReadF64()
        {
            double result = this.ReadF64(this._position);
            this._position += 8;
            return result;
        }
    }
}
