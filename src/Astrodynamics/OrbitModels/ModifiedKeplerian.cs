using Astrodynamics.Attributes;
using Astrodynamics.Enums;
using Astrodynamics.MiscModels;
using JetBrains.Annotations;
using UnitsNet;

namespace Astrodynamics.OrbitModels;

[UsedImplicitly]
public class ModifiedKeplerian
{
	public ModifiedKeplerian(Length apogee, Length perigee, Angle inclination, Duration period)
	{
		Apogee = apogee;
		Perigee = perigee;
		Inclination = inclination;
		Period = period;
	}

	[CommonSymbol("Rₐ")]
	public Length Apogee { get; }
	
	[CommonSymbol("Rₚ")]
	public Length Perigee { get;  }
	
	[CommonSymbol("𝑖")]
	public Angle Inclination { get; }
	
	[CommonSymbol("T")]
	public Duration Period { get; }
}