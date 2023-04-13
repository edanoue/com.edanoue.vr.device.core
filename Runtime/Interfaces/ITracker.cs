// Copyright Edanoue, Inc. All Rights Reserved.

using System;

namespace Edanoue.VR.Device.Core
{
    public interface ITracker
    {
        /// <summary>
        /// Returns whether device is currently connected.
        /// Always return true if for headset on native stand-alone build.
        /// </summary>
        public bool IsConnected { get; }

        /// <summary>
        /// Tracker position (Unity space Vector3)
        /// </summary>
        public (float X, float Y, float Z) Position { get; }

        /// <summary>
        /// Tracker rotation (Unity space Quaternion)
        /// </summary>
        public (float W, float X, float Y, float Z) Rotation { get; }


        /// <summary>
        /// Invoke when established connection with device.
        /// </summary>
        public event Action EstablishedConnection;

        /// <summary>
        /// Invoke when lost connection with device.
        /// </summary>
        public event Action LostConnection;
    }
}