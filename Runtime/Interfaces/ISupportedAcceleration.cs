// Copyright Edanoue, Inc. All Rights Reserved.

namespace Edanoue.VR.Device.Core
{
    /// <summary>
    ///     Through this interface, acceleration data can be obtained.
    /// </summary>
    public interface ISupportedAcceleration
    {
        /// <summary>
        ///     Gets the linear acceleration.
        /// </summary>
        public (float X, float Y, float Z) LinearAcceleration { get; }

        /// <summary>
        ///     Gets the angular acceleration.
        /// </summary>
        public (float X, float Y, float Z) AngularAcceleration { get; }
    }
}