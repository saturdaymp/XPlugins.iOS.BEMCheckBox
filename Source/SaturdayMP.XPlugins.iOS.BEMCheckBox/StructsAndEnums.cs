using ObjCRuntime;

namespace SaturdayMP.XPlugins.iOS
{

	[Native]
	public enum BEMBoxType : long
	{
		Circle = 0,
		Square = 1
	}

	[Native]
	public enum BEMAnimationType : long
	{
		Stroke = 0,
		Fill = 1,
		Bounce = 2,
		Flat = 3,
		OneStroke = 4,
		Fade = 5
	}
}
