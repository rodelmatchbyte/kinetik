// Type: System.IO.MemoryStream
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security;

namespace System.IO
{
    /// <summary>
    /// Creates a stream whose backing store is memory.
    /// </summary>
    /// <filterpriority>2</filterpriority>
    [ComVisible(true)]
    [Serializable]
    public class MemoryStream : Stream
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.IO.MemoryStream"/> class with an expandable capacity initialized to zero.
        /// </summary>
        public MemoryStream();

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.IO.MemoryStream"/> class with an expandable capacity initialized as specified.
        /// </summary>
        /// <param name="capacity">The initial size of the internal array in bytes. </param><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity"/> is negative. </exception>
        public MemoryStream(int capacity);

        /// <summary>
        /// Initializes a new non-resizable instance of the <see cref="T:System.IO.MemoryStream"/> class based on the specified byte array.
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create the current stream. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> is null. </exception>
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        public MemoryStream(byte[] buffer);

        /// <summary>
        /// Initializes a new non-resizable instance of the <see cref="T:System.IO.MemoryStream"/> class based on the specified byte array with the <see cref="P:System.IO.MemoryStream.CanWrite"/> property set as specified.
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param><param name="writable">The setting of the <see cref="P:System.IO.MemoryStream.CanWrite"/> property, which determines whether the stream supports writing. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> is null. </exception>
        public MemoryStream(byte[] buffer, bool writable);

        /// <summary>
        /// Initializes a new non-resizable instance of the <see cref="T:System.IO.MemoryStream"/> class based on the specified region (index) of a byte array.
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param><param name="index">The index into <paramref name="buffer"/> at which the stream begins. </param><param name="count">The length of the stream in bytes. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> or <paramref name="count"/> is less than zero. </exception><exception cref="T:System.ArgumentException">The sum of <paramref name="index"/> and <paramref name="count"/> is greater than the length of <paramref name="buffer"/>. </exception>
        public MemoryStream(byte[] buffer, int index, int count);

        /// <summary>
        /// Initializes a new non-resizable instance of the <see cref="T:System.IO.MemoryStream"/> class based on the specified region of a byte array, with the <see cref="P:System.IO.MemoryStream.CanWrite"/> property set as specified.
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param><param name="index">The index in <paramref name="buffer"/> at which the stream begins. </param><param name="count">The length of the stream in bytes. </param><param name="writable">The setting of the <see cref="P:System.IO.MemoryStream.CanWrite"/> property, which determines whether the stream supports writing. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> or <paramref name="count"/> are negative. </exception><exception cref="T:System.ArgumentException">The sum of <paramref name="index"/> and <paramref name="count"/> is greater than the length of <paramref name="buffer"/>. </exception>
        public MemoryStream(byte[] buffer, int index, int count, bool writable);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.IO.MemoryStream"/> class based on the specified region of a byte array, with the <see cref="P:System.IO.MemoryStream.CanWrite"/> property set as specified, and the ability to call <see cref="M:System.IO.MemoryStream.GetBuffer"/> set as specified.
        /// </summary>
        /// <param name="buffer">The array of unsigned bytes from which to create this stream. </param><param name="index">The index into <paramref name="buffer"/> at which the stream begins. </param><param name="count">The length of the stream in bytes. </param><param name="writable">The setting of the <see cref="P:System.IO.MemoryStream.CanWrite"/> property, which determines whether the stream supports writing. </param><param name="publiclyVisible">true to enable <see cref="M:System.IO.MemoryStream.GetBuffer"/>, which returns the unsigned byte array from which the stream was created; otherwise, false. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="index"/> or <paramref name="count"/> is negative. </exception><exception cref="T:System.ArgumentException">The buffer length minus <paramref name="index"/> is less than <paramref name="count"/>. </exception>
        public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible);

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="T:System.IO.MemoryStream"/> class and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing);

        /// <summary>
        /// Overrides <see cref="M:System.IO.Stream.Flush"/> so that no action is performed.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public override void Flush();

        /// <summary>
        /// Returns the array of unsigned bytes from which this stream was created.
        /// </summary>
        /// 
        /// <returns>
        /// The byte array from which this stream was created, or the underlying array if a byte array was not provided to the <see cref="T:System.IO.MemoryStream"/> constructor during construction of the current instance.
        /// </returns>
        /// <exception cref="T:System.UnauthorizedAccessException">The MemoryStream instance was not created with a publicly visible buffer. </exception><filterpriority>2</filterpriority>
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        public virtual byte[] GetBuffer();

        /// <summary>
        /// Reads a block of bytes from the current stream and writes the data to <paramref name="buffer"/>.
        /// </summary>
        /// 
        /// <returns>
        /// The total number of bytes written into the buffer. This can be less than the number of bytes requested if that number of bytes are not currently available, or zero if the end of the stream is reached before any bytes are read.
        /// </returns>
        /// <param name="buffer">When this method returns, contains the specified byte array with the values between <paramref name="offset"/> and (<paramref name="offset"/> + <paramref name="count"/> - 1) replaced by the characters read from the current stream. </param><param name="offset">The byte offset in <paramref name="buffer"/> at which to begin reading. </param><param name="count">The maximum number of bytes to read. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> is null. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> or <paramref name="count"/> is negative. </exception><exception cref="T:System.ArgumentException"><paramref name="offset"/> subtracted from the buffer length is less than <paramref name="count"/>. </exception><exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCritical]
        public override int Read([In, Out] byte[] buffer, int offset, int count);

        /// <summary>
        /// Reads a byte from the current stream.
        /// </summary>
        /// 
        /// <returns>
        /// The byte cast to a <see cref="T:System.Int32"/>, or -1 if the end of the stream has been reached.
        /// </returns>
        /// <exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception><filterpriority>2</filterpriority>
        public override int ReadByte();

        /// <summary>
        /// Sets the position within the current stream to the specified value.
        /// </summary>
        /// 
        /// <returns>
        /// The new position within the stream, calculated by combining the initial reference point and the offset.
        /// </returns>
        /// <param name="offset">The new position within the stream. This is relative to the <paramref name="loc"/> parameter, and can be positive or negative. </param><param name="loc">A value of type <see cref="T:System.IO.SeekOrigin"/>, which acts as the seek reference point. </param><exception cref="T:System.IO.IOException">Seeking is attempted before the beginning of the stream. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> is greater than <see cref="F:System.Int32.MaxValue"/>. </exception><exception cref="T:System.ArgumentException">There is an invalid <see cref="T:System.IO.SeekOrigin"/>. -or-<paramref name="offset"/> caused an arithmetic overflow.</exception><exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception><filterpriority>2</filterpriority>
        public override long Seek(long offset, SeekOrigin loc);

        /// <summary>
        /// Sets the length of the current stream to the specified value.
        /// </summary>
        /// <param name="value">The value at which to set the length. </param><exception cref="T:System.NotSupportedException">The current stream is not resizable and <paramref name="value"/> is larger than the current capacity.-or- The current stream does not support writing. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="value"/> is negative or is greater than the maximum length of the <see cref="T:System.IO.MemoryStream"/>, where the maximum length is(<see cref="F:System.Int32.MaxValue"/> - origin), and origin is the index into the underlying buffer at which the stream starts. </exception><filterpriority>2</filterpriority>
        public override void SetLength(long value);

        /// <summary>
        /// Writes the stream contents to a byte array, regardless of the <see cref="P:System.IO.MemoryStream.Position"/> property.
        /// </summary>
        /// 
        /// <returns>
        /// A new byte array.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        [SecuritySafeCritical]
        public virtual byte[] ToArray();

        /// <summary>
        /// Writes a block of bytes to the current stream using data read from buffer.
        /// </summary>
        /// <param name="buffer">The buffer to write data from. </param><param name="offset">The byte offset in <paramref name="buffer"/> at which to begin writing from. </param><param name="count">The maximum number of bytes to write. </param><exception cref="T:System.ArgumentNullException"><paramref name="buffer"/> is null. </exception><exception cref="T:System.NotSupportedException">The stream does not support writing. For additional information see <see cref="P:System.IO.Stream.CanWrite"/>.-or- The current position is closer than <paramref name="count"/> bytes to the end of the stream, and the capacity cannot be modified. </exception><exception cref="T:System.ArgumentException"><paramref name="offset"/> subtracted from the buffer length is less than <paramref name="count"/>. </exception><exception cref="T:System.ArgumentOutOfRangeException"><paramref name="offset"/> or <paramref name="count"/> are negative. </exception><exception cref="T:System.IO.IOException">An I/O error occurs. </exception><exception cref="T:System.ObjectDisposedException">The current stream instance is closed. </exception><filterpriority>2</filterpriority>
        [SecuritySafeCritical]
        public override void Write(byte[] buffer, int offset, int count);

        /// <summary>
        /// Writes a byte to the current stream at the current position.
        /// </summary>
        /// <param name="value">The byte to write. </param><exception cref="T:System.NotSupportedException">The stream does not support writing. For additional information see <see cref="P:System.IO.Stream.CanWrite"/>.-or- The current position is at the end of the stream, and the capacity cannot be modified. </exception><exception cref="T:System.ObjectDisposedException">The current stream is closed. </exception><filterpriority>2</filterpriority>
        public override void WriteByte(byte value);

        /// <summary>
        /// Writes the entire contents of this memory stream to another stream.
        /// </summary>
        /// <param name="stream">The stream to write this memory stream to. </param><exception cref="T:System.ArgumentNullException"><paramref name="stream"/> is null. </exception><exception cref="T:System.ObjectDisposedException">The current or target stream is closed. </exception><filterpriority>2</filterpriority>
        public virtual void WriteTo(Stream stream);

        /// <summary>
        /// Provides support for a <see cref="T:System.Diagnostics.Contracts.Contract"/>.
        /// </summary>
        protected override void ObjectInvariant();

        /// <summary>
        /// Gets a value indicating whether the current stream supports reading.
        /// </summary>
        /// 
        /// <returns>
        /// true if the stream is open.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override bool CanRead { get; }

        /// <summary>
        /// Gets a value indicating whether the current stream supports seeking.
        /// </summary>
        /// 
        /// <returns>
        /// true if the stream is open.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override bool CanSeek { get; }

        /// <summary>
        /// Gets a value indicating whether the current stream supports writing.
        /// </summary>
        /// 
        /// <returns>
        /// true if the stream supports writing; otherwise, false.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public override bool CanWrite { get; }

        /// <summary>
        /// Gets or sets the number of bytes allocated for this stream.
        /// </summary>
        /// 
        /// <returns>
        /// The length of the usable portion of the buffer for the stream.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">A capacity is set that is negative or less than the current length of the stream. </exception><exception cref="T:System.ObjectDisposedException">The current stream is closed. </exception><exception cref="T:System.NotSupportedException">set is invoked on a stream whose capacity cannot be modified. </exception><filterpriority>2</filterpriority>
        public virtual int Capacity { get; [SecuritySafeCritical]
        set; }

        /// <summary>
        /// Gets the length of the stream in bytes.
        /// </summary>
        /// 
        /// <returns>
        /// The length of the stream in bytes.
        /// </returns>
        /// <exception cref="T:System.ObjectDisposedException">The stream is closed. </exception><filterpriority>2</filterpriority>
        public override long Length { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; }

        /// <summary>
        /// Gets or sets the current position within the stream.
        /// </summary>
        /// 
        /// <returns>
        /// The current position within the stream.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">The position is set to a negative value or a value greater than <see cref="F:System.Int32.MaxValue"/>. </exception><exception cref="T:System.ObjectDisposedException">The stream is closed. </exception><filterpriority>2</filterpriority>
        public override long Position { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; set; }
    }
}
