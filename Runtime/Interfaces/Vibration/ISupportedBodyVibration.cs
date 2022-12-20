// Copyright Edanoue, Inc. All Rights Reserved.

namespace Edanoue.VR.Device.Core
{
    public interface ISupportedBodyVibration
    {
        /// <summary>
        ///     本体 を振動させます
        /// </summary>
        /// <remarks>
        ///     確認済みの対応機種
        ///     - Oculus Quest 2 Touch Controller
        ///     - Meta Quest Pro Controller
        /// </remarks>
        /// <param name="frequency"></param>
        /// <param name="amplitude"></param>
        void SetVibration(float frequency, float amplitude);
    }
}