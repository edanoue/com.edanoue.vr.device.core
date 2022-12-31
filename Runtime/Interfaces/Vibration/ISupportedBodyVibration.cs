// Copyright Edanoue, Inc. All Rights Reserved.

namespace Edanoue.VR.Device.Core
{
    public interface ISupportedBodyVibration
    {
        /// <summary>
        ///     本体 (握っている部分) のバイブレーターを振動させます
        ///     Oculus Device では 2秒後に自動で振動が終了します.
        ///     振動を終了させる場合は `SetVibration(0, 0)` を呼んで下さい.
        /// </summary>
        /// <remarks>
        ///     確認済みの対応機種
        ///     - Oculus Quest 2 Touch Controller
        ///     - Meta Quest Pro Controller
        /// </remarks>
        /// <param name="frequency">周波数, 振動の間隔, 期待する範囲は [0, 1]</param>
        /// <param name="amplitude">振幅, 振動の強さ,期待する範囲は [0, 1]</param>
        void SetVibration(float frequency, float amplitude);
    }
}