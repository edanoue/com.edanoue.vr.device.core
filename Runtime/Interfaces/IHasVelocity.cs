namespace Edanoue.VR.Device.Core
{
    public interface IHasVelocity
    {
        public (float X, float Y, float Z) LinearVelocity { get; }
        public (float X, float Y, float Z) LinearAcceleration { get; }
        public (float X, float Y, float Z) AngularVelocity { get; }
        public (float X, float Y, float Z) AngularAcceleration { get; }
    }
}