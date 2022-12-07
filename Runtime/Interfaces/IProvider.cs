namespace Edanoue.VR.Device.Core
{
    /// <summary>
    /// </summary>
    public interface IProvider
    {
        /// <summary>
        ///     Get headset.
        /// </summary>
        public IHeadset Headset { get; }

        /// <summary>
        ///     Get left controller.
        /// </summary>
        public IController LeftController { get; }

        /// <summary>
        ///     Get right controller.
        /// </summary>
        public IController RightController { get; }

        /// <summary>
        ///     Get display available refresh rate list
        /// </summary>
        public float[] AvailableRefreshRates { get; }

        /// <summary>
        ///     Get or set display refresh rate
        /// </summary>
        public float RefreshRate { get; set; }
    }
}