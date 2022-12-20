// Copyright Edanoue, Inc. All Rights Reserved.

namespace Edanoue.VR.Device.Core
{
    /// <summary>
    ///     Through this interface, battery data can be obtained.
    /// </summary>
    public interface ISupportedBattery
    {
        /// <summary>
        ///     Get battery
        ///     Return value is [0.0, 1.0] range (1 means full, 0 means empty)
        /// </summary>
        public float Battery { get; }
    }
}