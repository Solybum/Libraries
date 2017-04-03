using System;

namespace Libraries.ByteArray
{
    public partial class ByteArray
    {
        /// <summary>
        /// Writes a <see cref="bool"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(bool value)
        {
            _buffer[_position] = (byte)(value ? 1 : 0);
            _position += 1;
        }
        /// <summary>
        /// Writes a <see cref="sbyte"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(sbyte value)
        {
            _buffer[_position] = (byte)value;
            _position += 1;
        }
        /// <summary>
        /// Writes a <see cref="byte"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(byte value)
        {
            _buffer[_position] = value;
            _position += 1;
        }
        /// <summary>
        /// Writes a <see cref="short"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(short value)
        {
            _buffer[_position + 0] = (byte)value;
            _buffer[_position + 1] = (byte)(value >> 8);
            _position += 2;
        }
        /// <summary>
        /// Writes a <see cref="ushort"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(ushort value)
        {
            _buffer[_position + 0] = (byte)value;
            _buffer[_position + 1] = (byte)(value >> 8);
            _position += 2;
        }
        /// <summary>
        /// Writes a <see cref="int"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(int value)
        {
            _buffer[_position + 0] = (byte)value;
            _buffer[_position + 1] = (byte)(value >> 8);
            _buffer[_position + 2] = (byte)(value >> 16);
            _buffer[_position + 3] = (byte)(value >> 24);
            _position += 4;
        }
        /// <summary>
        /// Writes a <see cref="uint"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(uint value)
        {
            _buffer[_position + 0] = (byte)value;
            _buffer[_position + 1] = (byte)(value >> 8);
            _buffer[_position + 2] = (byte)(value >> 16);
            _buffer[_position + 3] = (byte)(value >> 24);
            _position += 4;
        }
        /// <summary>
        /// Writes a <see cref="long"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(long value)
        {
            _buffer[_position + 0] = (byte)value;
            _buffer[_position + 1] = (byte)(value >> 8);
            _buffer[_position + 2] = (byte)(value >> 16);
            _buffer[_position + 3] = (byte)(value >> 24);
            _buffer[_position + 4] = (byte)(value >> 32);
            _buffer[_position + 5] = (byte)(value >> 40);
            _buffer[_position + 6] = (byte)(value >> 48);
            _buffer[_position + 7] = (byte)(value >> 56);
            _position += 8;
        }
        /// <summary>
        /// Writes a <see cref="ulong"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(ulong value)
        {
            _buffer[_position + 0] = (byte)value;
            _buffer[_position + 1] = (byte)(value >> 8);
            _buffer[_position + 2] = (byte)(value >> 16);
            _buffer[_position + 3] = (byte)(value >> 24);
            _buffer[_position + 4] = (byte)(value >> 32);
            _buffer[_position + 5] = (byte)(value >> 40);
            _buffer[_position + 6] = (byte)(value >> 48);
            _buffer[_position + 7] = (byte)(value >> 56);
            _position += 8;
        }
        /// <summary>
        /// Writes a <see cref="float"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(float value)
        {
            Array.Copy(BitConverter.GetBytes(value), 0, _buffer, _position, 4);
            _position += 4;
        }
        /// <summary>
        /// Writes a <see cref="double"/> advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public void Write(double value)
        {
            Array.Copy(BitConverter.GetBytes(value), 0, _buffer, _position, 8);
            _position += 8;
        }
 
        /// <summary>
        /// Writes a <see cref="bool"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(bool value, int position)
        {
            _buffer[position] = (byte)(value ? 1 : 0);
            // position += 1;
        }
        /// <summary>
        /// Writes a <see cref="sbyte"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(sbyte value, int position)
        {
            _buffer[position] = (byte)value;
            // position += 1;
        }
        /// <summary>
        /// Writes a <see cref="byte"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(byte value, int position)
        {
            _buffer[position] = value;
            // position += 1;
        }
        /// <summary>
        /// Writes a <see cref="short"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(short value, int position)
        {
            _buffer[position + 0] = (byte)value;
            _buffer[position + 1] = (byte)(value >> 8);
            // position += 2;
        }
        /// <summary>
        /// Writes a <see cref="ushort"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(ushort value, int position)
        {
            _buffer[position + 0] = (byte)value;
            _buffer[position + 1] = (byte)(value >> 8);
            // position += 2;
        }
        /// <summary>
        /// Writes a <see cref="int"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(int value, int position)
        {
            _buffer[position + 0] = (byte)value;
            _buffer[position + 1] = (byte)(value >> 8);
            _buffer[position + 2] = (byte)(value >> 16);
            _buffer[position + 3] = (byte)(value >> 24);
            // position += 4;
        }
        /// <summary>
        /// Writes a <see cref="uint"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(uint value, int position)
        {
            _buffer[position + 0] = (byte)value;
            _buffer[position + 1] = (byte)(value >> 8);
            _buffer[position + 2] = (byte)(value >> 16);
            _buffer[position + 3] = (byte)(value >> 24);
            // position += 4;
        }
        /// <summary>
        /// Writes a <see cref="long"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(long value, int position)
        {
            _buffer[position + 0] = (byte)value;
            _buffer[position + 1] = (byte)(value >> 8);
            _buffer[position + 2] = (byte)(value >> 16);
            _buffer[position + 3] = (byte)(value >> 24);
            _buffer[position + 4] = (byte)(value >> 32);
            _buffer[position + 5] = (byte)(value >> 40);
            _buffer[position + 6] = (byte)(value >> 48);
            _buffer[position + 7] = (byte)(value >> 56);
            // position += 8;
        }
        /// <summary>
        /// Writes a <see cref="ulong"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(ulong value, int position)
        {
            _buffer[position + 0] = (byte)value;
            _buffer[position + 1] = (byte)(value >> 8);
            _buffer[position + 2] = (byte)(value >> 16);
            _buffer[position + 3] = (byte)(value >> 24);
            _buffer[position + 4] = (byte)(value >> 32);
            _buffer[position + 5] = (byte)(value >> 40);
            _buffer[position + 6] = (byte)(value >> 48);
            _buffer[position + 7] = (byte)(value >> 56);
            // position += 8;
        }
        /// <summary>
        /// Writes a <see cref="float"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(float value, int position)
        {
            Array.Copy(BitConverter.GetBytes(value), 0, _buffer, position, 4);
            // position += 4;
        }
        /// <summary>
        /// Writes a <see cref="double"/> without advancing the internal position
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position">ByteArray index to write to</param>
        /// <returns></returns>
        public void Write(double value, int position)
        {
            Array.Copy(BitConverter.GetBytes(value), 0, _buffer, position, 8);
            // position += 8;
        }
    }
}
