using Astrodynamics.Attributes;
using JetBrains.Annotations;
using UnitsNet;

namespace Astrodynamics.OrbitModels;

[UsedImplicitly]
public class ModifiedKeplerian
{
	public ModifiedKeplerian(Length apogee, Length perigee, Angle inclination, Duration period, Angle rightAscensionAscendingNode, DateTime? epoch = null)
	{
		Apogee = apogee;
		Perigee = perigee;
		Inclination = inclination;
		Period = period;
		RightAscensionAscendingNode = rightAscensionAscendingNode;
		Epoch = epoch;
	}

	[CommonSymbol("Rₐ")]
	public Length Apogee { get; }
	
	[CommonSymbol("Rₚ")]
	public Length Perigee { get;  }
	
	[CommonSymbol("𝑖")]
	public Angle Inclination { get; }
	
	[CommonSymbol("T")]
	public Duration Period { get; }
	
	[CommonSymbol("Ω")]
	public Angle RightAscensionAscendingNode { get; }
	
	[CommonSymbol("t₀")]
	public DateTime? Epoch { get; }
	
	
}