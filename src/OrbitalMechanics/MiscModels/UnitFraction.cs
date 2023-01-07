using System.Globalization;
using System.Numerics;
using OrbitalMechanics.Exceptions;

namespace OrbitalMechanics.MiscModels;

public class UnitFraction : INumber<UnitFraction>
{
	private decimal _innerValue;

	private decimal InnerValue
	{
		get => _innerValue;
		set
		{
			if (!InValidRange(value)) throw new UnitFractionOverflowException(value);
			_innerValue = value;
		}
	}

	private UnitFraction(decimal d)
	{
		InnerValue = d;
	}

	public static explicit operator decimal(UnitFraction u) => u.InnerValue;

	public static explicit operator UnitFraction(decimal d) => new(d);

	public int CompareTo(object? obj) => InnerValue.CompareTo(obj);

	public int CompareTo(UnitFraction? other) => InnerValue.CompareTo(other?.InnerValue);

	public bool Equals(UnitFraction? other) => InnerValue.Equals(other?.InnerValue);

	public string ToString(string? format, IFormatProvider? formatProvider) => InnerValue.ToString(format, formatProvider);

	public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) =>
		InnerValue.TryFormat(destination, out charsWritten, format, provider);

	public static UnitFraction Parse(string s, IFormatProvider? provider) => (UnitFraction)decimal.Parse(s, provider);

	public static bool TryParse(string? s, IFormatProvider? provider, out UnitFraction result)
	{
		bool initialSuccess = decimal.TryParse(s, provider, out decimal decResult);
		bool validRange = InValidRange(decResult);

		if (initialSuccess && validRange)
		{
			result = (UnitFraction)decResult;
			return true;
		}

		result = null!;
		return false;
	}

	public static UnitFraction Parse(ReadOnlySpan<char> s, IFormatProvider? provider) => (UnitFraction)decimal.Parse(s, provider);

	public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, out UnitFraction result)
	{
		try
		{
			bool initialSuccess = decimal.TryParse(s, provider, out decimal decResult);
			bool validRange = InValidRange(decResult);

			if (initialSuccess && validRange)
			{
				result = (UnitFraction)decResult;
				return true;
			}
		}
		catch
		{
			// ignored
		}

		result = null!;
		return false;
	}

	public static UnitFraction operator +(UnitFraction left, UnitFraction right) => new(left.InnerValue + right.InnerValue);

	public static UnitFraction AdditiveIdentity => Zero;

	public static bool operator ==(UnitFraction? left, UnitFraction? right) => left?.InnerValue == right?.InnerValue;

	public static bool operator !=(UnitFraction? left, UnitFraction? right) => left?.InnerValue != right?.InnerValue;

	public static bool operator >(UnitFraction left, UnitFraction right) => left.InnerValue > right.InnerValue;

	public static bool operator >=(UnitFraction left, UnitFraction right) => left.InnerValue >= right.InnerValue;

	public static bool operator <(UnitFraction left, UnitFraction right) => left.InnerValue < right.InnerValue;

	public static bool operator <=(UnitFraction left, UnitFraction right) => left.InnerValue <= right.InnerValue;

	public static UnitFraction operator --(UnitFraction value) => new(--value.InnerValue);

	public static UnitFraction operator /(UnitFraction left, UnitFraction right) => new(left.InnerValue / right.InnerValue);

	public static UnitFraction operator ++(UnitFraction value) => new(++value.InnerValue);
	public static UnitFraction operator %(UnitFraction left, UnitFraction right) => new(left.InnerValue % right.InnerValue);

	public static UnitFraction MultiplicativeIdentity => One;
	public static UnitFraction operator *(UnitFraction left, UnitFraction right) => new(left.InnerValue * right.InnerValue);

	public static UnitFraction operator -(UnitFraction left, UnitFraction right) => new(left.InnerValue - right.InnerValue);

	public static UnitFraction operator -(UnitFraction value)  => new(-value.InnerValue); // This *should* fail.

	public static UnitFraction operator +(UnitFraction value)  => value;

	public static UnitFraction Abs(UnitFraction value) => value;

	public static bool IsCanonical(UnitFraction value) => true;

	public static bool IsComplexNumber(UnitFraction value) => false;

	public static bool IsEvenInteger(UnitFraction value) => value.InnerValue == 0;

	public static bool IsFinite(UnitFraction value) => true;

	public static bool IsImaginaryNumber(UnitFraction value) => false;

	public static bool IsInfinity(UnitFraction value) => false;

	public static bool IsInteger(UnitFraction value) => false;

	public static bool IsNaN(UnitFraction value) => false;

	public static bool IsNegative(UnitFraction value) => false;

	public static bool IsNegativeInfinity(UnitFraction value) => false;

	public static bool IsNormal(UnitFraction value) => true;

	public static bool IsOddInteger(UnitFraction value) => value.InnerValue == 1;

	public static bool IsPositive(UnitFraction value) => true;
	public static bool IsPositiveInfinity(UnitFraction value) => false;

	public static bool IsRealNumber(UnitFraction value) => true;

	public static bool IsSubnormal(UnitFraction value) => false;

	public static bool IsZero(UnitFraction value) => value.InnerValue == 0;

	public static UnitFraction MaxMagnitude(UnitFraction x, UnitFraction y) => x.InnerValue > y.InnerValue ? x : y;
	public static UnitFraction MaxMagnitudeNumber(UnitFraction x, UnitFraction y) => x.InnerValue > y.InnerValue ? x : y;

	public static UnitFraction MinMagnitude(UnitFraction x, UnitFraction y) => x.InnerValue < y.InnerValue ? x : y;
	public static UnitFraction MinMagnitudeNumber(UnitFraction x, UnitFraction y) => x.InnerValue < y.InnerValue ? x : y;

	public static UnitFraction Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider) => (UnitFraction)decimal.Parse(s, style, provider);

	public static UnitFraction Parse(string s, NumberStyles style, IFormatProvider? provider) => (UnitFraction)decimal.Parse(s, style, provider);


	public static bool TryConvertFromChecked<TOther>(TOther value, out UnitFraction result) where TOther : INumberBase<TOther>
	{
		decimal? decVal = value switch
		{
			byte => (byte)(object)value,
			char => (char)(object)value,
			ushort => (ushort)(object)value,
			uint => (uint)(object)value,
			ulong => (ulong)(object)value,
			UInt128 => (ulong)(object)value,
			nuint => (nuint)(object)value,
			_ => null
		};

		if (decVal is null)
		{
			result = null!;
			return false;
		}

		result = new((decimal)decVal);
		return true;
	}

	public static bool TryConvertFromSaturating<TOther>(TOther value, out UnitFraction result) where TOther : INumberBase<TOther> => TryConvertFromChecked(value, out result);

	public static bool TryConvertFromTruncating<TOther>(TOther value, out UnitFraction result) where TOther : INumberBase<TOther> => TryConvertFromChecked(value, out result);

	public static bool TryConvertToChecked<TOther>(UnitFraction value, out TOther result) where TOther : INumberBase<TOther> => TOther.TryConvertFromChecked(value.InnerValue, out result!);


	public static bool TryConvertToSaturating<TOther>(UnitFraction value, out TOther result) where TOther : INumberBase<TOther> => TOther.TryConvertFromSaturating(value.InnerValue, out result!);

	public static bool TryConvertToTruncating<TOther>(UnitFraction value, out TOther result) where TOther : INumberBase<TOther> => TOther.TryConvertFromTruncating(value.InnerValue, out result!);

	public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, out UnitFraction result)
	{
		bool initialSuccess = decimal.TryParse(s, provider, out decimal decResult);
		bool validRange = InValidRange(decResult);

		if (initialSuccess && validRange)
		{
			result = (UnitFraction)decResult;
			return true;
		}

		result = null!;
		return false;
	}

	public static bool TryParse(string? s, NumberStyles style, IFormatProvider? provider, out UnitFraction result)
	{
		bool initialSuccess = decimal.TryParse(s, provider, out decimal decResult);
		bool validRange = InValidRange(decResult);

		if (initialSuccess && validRange)
		{
			result = (UnitFraction)decResult;
			return true;
		}

		result = null!;
		return false;
	}

	public static UnitFraction One => new(1);
	public static int Radix => 10;
	public static UnitFraction Zero => new(0);


	private static bool InValidRange(decimal d) => d is >= 0 and <= 1;
}