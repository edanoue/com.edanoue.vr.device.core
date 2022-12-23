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
        ///     ユーザーが現在アプリケーションに集中しているかどうかを取得.
        /// </summary>
        public bool HasInputFocus { get; }

        /// <summary>
        /// </summary>
        public event Action Mounted;

        /// <summary>
        /// </summary>
        public event Action Unmounted;

        /// <summary>
        ///     ユーザーがアプリケーションに集中しなくなったときに呼ばれます
        ///     Quest では 以下のときに呼ばれるイベントです
        ///     - ユーザーが外界認識をした
        ///     - ユーザーが HDM を脱いだ
        ///     - システムのメニューボタンを押した
        ///     - HMD のトラッキングが失われた
        /// </summary>
        public event Action InputFocusAcquired;

        /// <summary>
        ///     ユーザーがアプリケーションに集中したときに呼ばれます
        ///     Quest では 以下のときに呼ばれるイベントです
        ///     - ユーザーが外界認識をやめた
        ///     - ユーザーが HDM を被った
        ///     - システムのメニューボタンを閉じた
        ///     - HMD のトラッキングが戻った
        /// </summary>
        public event Action InputFocusLost;
    }
}