namespace Astrodynamics.Attributes;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class CommonSymbolAttribute: Attribute
{
	public CommonSymbolAttribute(string value)
	{
		Value = value;
	}

	public string Value { get; }
}