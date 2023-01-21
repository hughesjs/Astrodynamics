using Astrodynamics.Attributes;
using Astrodynamics.Enums;
using Astrodynamics.MiscModels;
using JetBrains.Annotations;
using UnitsNet;

namespace Astrodynamics.OrbitModels;

[UsedImplicitly]
public class ClassicalKeplerian
{
	public ClassicalKeplerian(Angle argumentOfPeriapsis, Angle inclination, UnitFraction eccentricity, Angle rightAscensionAscendingNode, Length semiMajorAxis, ReferenceFrame referenceFrame, Angle? trueAnomaly = null, DateTime? epoch = null)
	{
		ArgumentOfPeriapsis = argumentOfPeriapsis;
		Inclination = inclination;
		Eccentricity = eccentricity;
		RightAscensionAscendingNode = rightAscensionAscendingNode;
		SemiMajorAxis = semiMajorAxis;
		ReferenceFrame = referenceFrame;
		TrueAnomaly = trueAnomaly;
		Epoch = epoch;
	}
	

	[CommonSymbol("ω")]
	public Angle ArgumentOfPeriapsis { get; }
	
	[CommonSymbol("𝑖")]
	public Angle Inclination { get; }
	
	[CommonSymbol("𝑒")]
	public UnitFraction Eccentricity { get; }
	
	[CommonSymbol("Ω")]
	public Angle RightAscensionAscendingNode { get; }
	
	[CommonSymbol("𝑎")]
	public Length SemiMajorAxis { get; }
	
	public ReferenceFrame ReferenceFrame { get; }
	
	[CommonSymbol("𝓥")]
	public Angle? TrueAnomaly { get; }
	
	[CommonSymbol("t₀")]
	public DateTime? Epoch { get; }
	
}