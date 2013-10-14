// Type: System.Object
// Assembly: mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\mscorlib.dll

using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace System
{
    /// <summary>
    /// Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.
    /// </summary>
    /// <filterpriority>1</filterpriority>
    [ClassInterface(ClassInterfaceType.AutoDual)]
    [ComVisible(true)]
    [Serializable]
    public class Object
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
        public Object();

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        public virtual string ToString();

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
        /// </summary>
        /// 
        /// <returns>
        /// true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
        /// </returns>
        /// <param name="obj">The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>. </param><filterpriority>2</filterpriority>
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        public virtual bool Equals(object obj);

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> instances are considered equal.
        /// </summary>
        /// 
        /// <returns>
        /// true if the objects are considered equal; otherwise, false.
        /// </returns>
        /// <param name="objA">The first <see cref="T:System.Object"/> to compare. </param><param name="objB">The second <see cref="T:System.Object"/> to compare. </param><filterpriority>2</filterpriority>
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        public static bool Equals(object objA, object objB);

        /// <summary>
        /// Determines whether the specified <see cref="T:System.Object"/> instances are the same instance.
        /// </summary>
        /// 
        /// <returns>
        /// true if <paramref name="objA"/> is the same instance as <paramref name="objB"/> or if both are null references; otherwise, false.
        /// </returns>
        /// <param name="objA">The first <see cref="T:System.Object"/> to compare. </param><param name="objB">The second <see cref="T:System.Object"/> to compare. </param><filterpriority>2</filterpriority>
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        public static bool ReferenceEquals(object objA, object objB);

        /// <summary>
        /// Serves as a hash function for a particular type.
        /// </summary>
        /// 
        /// <returns>
        /// A hash code for the current <see cref="T:System.Object"/>.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        public virtual int GetHashCode();

        /// <summary>
        /// Gets the <see cref="T:System.Type"/> of the current instance.
        /// </summary>
        /// 
        /// <returns>
        /// The <see cref="T:System.Type"/> instance that represents the exact runtime type of the current instance.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        [SecuritySafeCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        public Type GetType();

        /// <summary>
        /// Allows an <see cref="T:System.Object"/> to attempt to free resources and perform other cleanup operations before the <see cref="T:System.Object"/> is reclaimed by garbage collection.
        /// </summary>
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        ~Object();

        /// <summary>
        /// Creates a shallow copy of the current <see cref="T:System.Object"/>.
        /// </summary>
        /// 
        /// <returns>
        /// A shallow copy of the current <see cref="T:System.Object"/>.
        /// </returns>
        [SecuritySafeCritical]
        [MethodImpl(MethodImplOptions.InternalCall)]
        protected object MemberwiseClone();
    }
}
