using System;

namespace SQLite.Net
{
    public struct sqlstring : IComparable<sqlstring>, IEquatable<sqlstring>, ISerializable<String>
    {
        private readonly string @string;

        public sqlstring(string @string)
        {
            this.@string = @string;
        }

        public static implicit operator string(sqlstring @sqlstring)
        {
            return @sqlstring.@string;
        }

        public static implicit operator sqlstring(string @string)
        {
            return new sqlstring(@string);
        }

        public static bool operator >(sqlstring lhs, sqlstring rhs)
        {
            return lhs.CompareTo(rhs) > 0;
        }

        public static bool operator >=(sqlstring lhs, sqlstring rhs)
        {
            return lhs.CompareTo(rhs) >= 0;
        }

        public static bool operator <(sqlstring lhs, sqlstring rhs)
        {
            return lhs.CompareTo(rhs) < 0;
        }

        public static bool operator <=(sqlstring lhs, sqlstring rhs)
        {
            return lhs.CompareTo(rhs) <= 0;
        }

        public static bool operator ==(sqlstring lhs, sqlstring rhs)
        {
            return lhs.CompareTo(rhs) == 0;
        }

        public static bool operator !=(sqlstring lhs, sqlstring rhs)
        {
            return lhs.CompareTo(rhs) != 0;
        }

        public int CompareTo(sqlstring other)
        {
            return string.Compare(this.@string, other.@string, StringComparison.Ordinal);
        }

        public bool Equals(sqlstring other)
        {
            return this == other;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is sqlstring))
            {
                return false;
            }

            return this.Equals((sqlstring)obj);
        }

        public override int GetHashCode()
        {
            return this.@string.GetHashCode();
        }

        public override string ToString()
        {
            return this.@string;
        }

        public string Serialize()
        {
            return this.@string;
        }
    }
}