// Copyright Edanoue, Inc. All Rights Reserved.

using System;

namespace Edanoue.VR.Device.Core
{
    /// <summary>
    /// </summary>
    public abstract class HeadsetDisplayColorHandler
    {
        /// <summary>
        /// Set display color scale
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public abstract void SetColorScale(float x, float y, float z, float w);

        /// <summary>
        /// Set display color offset
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public abstract void SetColorOffset(float x, float y, float z, float w);

        public abstract void ResetColorScale();

        public abstract void ResetColorOffset();
    }

    public interface IHeadset : ITracker
    {
        /// <summary>
        /// Gets headset currently mounted.
        /// ヘッドセットを今かぶっているかどうかを取得.
        /// </summary>
        public bool IsMounted { get; }

        public HeadsetDisplayColorHandler DisplayColor { get; }

        /// <summary>
        /// </summary>
        public event Action Mounted;

        /// <summary>
        /// </summary>
        public event Action Unmounted;
    }
}