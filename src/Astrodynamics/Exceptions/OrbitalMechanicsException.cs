namespace Astrodynamics.Exceptions;

public class OrbitalMechanicsException: Exception
{
	public OrbitalMechanicsException(string? message, Exception? innerException) : base(message, innerException) { }
}