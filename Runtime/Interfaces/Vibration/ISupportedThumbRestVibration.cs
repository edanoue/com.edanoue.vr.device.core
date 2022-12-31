// Copyright Edanoue, Inc. All Rights Reserved.

namespace Edanoue.VR.Device.Core
{
    public interface ISupportedThumbRestVibration
    {
        /// <summary>
        ///     親指 (MqPro だと ThumbRest の部分) を振動させます
        /// </summary>
        /// <remarks>
        ///     確認済みの対応機種
        ///     - Meta Quest Pro Controller
        /// </remarks>
        /// <param name="frequency">周波数, 振動の間隔, 期待する範囲は [0, 1]</param>
        /// <param name="amplitude">振幅, 振動の強さ,期待する範囲は [0, 1]</param>
        void SetVibration(float frequency, float amplitude);
    }
}