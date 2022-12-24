// Copyright Edanoue, Inc. All Rights Reserved.

using System;

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

        /// <summary>
        ///     ユーザーが現在アプリケーションに集中しているかどうかを取得.
        /// </summary>
        public bool HasApplicationFocus { get; }

        /// <summary>
        ///     ユーザーがアプリケーションに集中しなくなったときに呼ばれます
        ///     Quest では 以下のときに呼ばれるイベントです
        ///     - ユーザーが外界認識をした
        ///     - ユーザーが HDM を脱いだ
        ///     - システムのメニューボタンを押した
        ///     - HMD のトラッキングが失われた
        /// </summary>
        public event Action ApplicationFocusAcquired;

        /// <summary>
        ///     ユーザーがアプリケーションに集中したときに呼ばれます
        ///     Quest では 以下のときに呼ばれるイベントです
        ///     - ユーザーが外界認識をやめた
        ///     - ユーザーが HDM を被った
        ///     - システムのメニューボタンを閉じた
        ///     - HMD のトラッキングが戻った
        /// </summary>
        public event Action ApplicationFocusLost;
    }
}