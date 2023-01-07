using OrbitalMechanics.Exceptions;
using OrbitalMechanics.MiscModels;

namespace OrbitalMechanics.Tests.MiscModels;

public class UnitFractionTests
{
	private const int Repeats = 5;
	
	[Theory]
	[MemberData(nameof(AdditionDataGenerator))]
	public void AddsLikeADecimal(decimal left, decimal right)
	{
		UnitFraction leftFraction = new(left);
		UnitFraction rightFraction = new(right);
		decimal expected = left + right;
		UnitFraction expectedFraction = new(expected);

		UnitFraction result = leftFraction + rightFraction;
		
		result.ShouldBe(expectedFraction);
	}
	
	[Theory]
	[MemberData(nameof(AdditionDataGenerator))]
	public void SubtractsLikeADecimal(decimal left, decimal right)
	{
		decimal smaller = decimal.MinMagnitude(left, right);
		decimal larger = decimal.MaxMagnitude(left, right);
		
		UnitFraction smallerFraction = new(smaller);
		UnitFraction largerFraction = new(larger);
		decimal expected = larger - smaller;
		UnitFraction expectedFraction = new(expected);

		UnitFraction result = largerFraction - smallerFraction;
		
		result.ShouldBe(expectedFraction);
	}
	
	[Theory]
	[MemberData(nameof(InRangeDataGenerator))]
	public void MultipliesLikeADecimal(decimal val)
	{
		const decimal scalar = 0.2m;
		UnitFraction fraction = new(val);
		UnitFraction rightFraction = new(scalar);
		decimal expected = val * scalar;
		UnitFraction expectedFraction = new(expected);

		UnitFraction result = fraction * rightFraction;
		
		result.ShouldBe(expectedFraction);
	}
	
	[Theory]
	[MemberData(nameof(InRangeDataGenerator))]
	public void DividesLikeADecimal(decimal val)
	{
		val /= 20; //Force into range
		const decimal scalar = 0.1m;
		UnitFraction fraction = new(val);
		UnitFraction rightFraction = new(scalar);
		decimal expected = val / scalar;
		UnitFraction expectedFraction = new(expected);

		UnitFraction result = fraction / rightFraction;
		
		result.ShouldBe(expectedFraction);
	}


	// These attributes being floats isn't a mistake... The compiler can't hack decimal literals in attributes
	[Theory]
	[InlineData(-0.1f)]
	[InlineData(-1f)]
	[InlineData(-2f)]
	[InlineData(1.1f)]
	[InlineData(2f)]
	public void ThrowsIfYouCreateOutOfRange(decimal val) => Should.Throw<UnitFractionOverflowException>(() => new UnitFraction(val));

	[Theory]
	[MemberData(nameof(InRangeDataGenerator))]
	[InlineData(1f)]
	[InlineData(0f)]
	public void DoesntThrowIfYouCreateInRange(decimal val) => Should.NotThrow(() => new UnitFraction(val));
	
	
	
	public static IEnumerable<object[]> AdditionDataGenerator()
	{
		List<object[]> decimalPairs = new();
		for (int i = 0; i < Repeats; i++)
		{
			decimal left = (decimal)Random.Shared.NextDouble() / 2;
			decimal right = (decimal)Random.Shared.NextDouble() / 2;
			decimalPairs.Add(new object[] {left, right});
		}

		return decimalPairs;
	}
	
	public static IEnumerable<object[]> InRangeDataGenerator()
	{
		List<object[]> values = new();
		for (int i = 0; i < Repeats; i++)
		{
			decimal val = (decimal)Random.Shared.NextDouble() / 2;
			values.Add(new object[] {val});
		}
		return values;
	}

}