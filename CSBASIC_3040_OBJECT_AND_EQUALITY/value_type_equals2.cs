// System.Object 와 System.ValueType 의 Equals() 구현 코드

namespace System
{
    public partial class Object
    {
        public virtual bool Equals(object? obj)
        {
            return this == obj;
        }
	}

    public abstract class ValueType
    {
        public override unsafe bool Equals([NotNullWhen(true)] object? obj)
        {
            if (null == obj)
            {
                return false;
            }

            if (GetType() != obj.GetType())
            {
                return false;
            }

            // if there are no GC references in this object we can avoid reflection
            // and do a fast memcmp
            if (CanCompareBits(this))
            {
                return SpanHelpers.SequenceEqual(
                    ref RuntimeHelpers.GetRawData(this),
                    ref RuntimeHelpers.GetRawData(obj),
                    RuntimeHelpers.GetMethodTable(this)->GetNumInstanceFieldBytes());
            }

            FieldInfo[] thisFields = GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            for (int i = 0; i < thisFields.Length; i++)
            {
                object? thisResult = thisFields[i].GetValue(this);
                object? thatResult = thisFields[i].GetValue(obj);

                if (thisResult == null)
                {
                    if (thatResult != null)
                        return false;
                }
                else
                if (!thisResult.Equals(thatResult))
                {
                    return false;
                }
            }

            return true;
        }
	}

	public readonly struct Int32 : IComparable, IConvertible, ISpanFormattable, IComparable<int>,
          						   IEquatable<int>, IBinaryInteger<int>, IMinMaxValue<int>,
          						   ISignedNumber<int>, IUtf8SpanFormattable, IBinaryIntegerParseAndFormatInfo<int>
    {
        public bool Equals(int obj)
        {
            return m_value == obj;
        }
	}
}