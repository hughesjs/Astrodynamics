namespace Astrodynamics.Exceptions;

public class UnitFractionOverflowException: OverflowException
{
	public UnitFractionOverflowException(decimal attemptedValue) : base("Unit fraction must be between 0 and 1")
	{
		AttemptedValue = attemptedValue;
	}

	public decimal AttemptedValue { get; }
}