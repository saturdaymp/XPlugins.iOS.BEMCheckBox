using ObjCRuntime;

namespace SaturdayMP.XPlugins.iOS
{
    // ReSharper disable once InconsistentNaming
    [Native]
    public enum BEMBoxType : long
    {
        Circle,
        Square
    }

    // ReSharper disable once UnusedMember.Global
    // ReSharper disable once InconsistentNaming
    [Native]
    public enum BEMAnimationType : long
    {
        Stroke,
        Fill,
        Bounce,
        Flat,
        OneStroke,
        Fade
    }
}

