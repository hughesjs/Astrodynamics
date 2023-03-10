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
	

	[CommonSymbol("Ï")]
	public Angle ArgumentOfPeriapsis { get; }
	
	[CommonSymbol("ğ")]
	public Angle Inclination { get; }
	
	[CommonSymbol("ğ")]
	public UnitFraction Eccentricity { get; }
	
	[CommonSymbol("Î©")]
	public Angle RightAscensionAscendingNode { get; }
	
	[CommonSymbol("ğ")]
	public Length SemiMajorAxis { get; }
	
	public ReferenceFrame ReferenceFrame { get; }
	
	[CommonSymbol("ğ¥")]
	public Angle? TrueAnomaly { get; }
	
	[CommonSymbol("tâ")]
	public DateTime? Epoch { get; }
	
}