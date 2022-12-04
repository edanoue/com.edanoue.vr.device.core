namespace Edanoue.VR.Device.Core
{
    /// <summary>
    ///     Through this interface, velocity data can be obtained.
    /// </summary>
    public interface ISupportedVelocity
    {
        /// <summary>
        ///     Gets the linear velocity.
        /// </summary>
        public (float X, float Y, float Z) LinearVelocity { get; }

        /// <summary>
        ///     Gets the angular velocity.
        /// </summary>
        public (float X, float Y, float Z) AngularVelocity { get; }
    }
}