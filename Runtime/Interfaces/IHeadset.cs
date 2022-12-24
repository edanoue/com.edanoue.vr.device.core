// Copyright Edanoue, Inc. All Rights Reserved.

using System;

namespace Edanoue.VR.Device.Core
{
    public interface IHeadset : ITracker
    {
        /// <summary>
        ///     Gets headset currently mounted.
        ///     ヘッドセットを今かぶっているかどうかを取得.
        /// </summary>
        public bool IsMounted { get; }


        /// <summary>
        /// </summary>
        public event Action Mounted;

        /// <summary>
        /// </summary>
        public event Action Unmounted;
    }
}