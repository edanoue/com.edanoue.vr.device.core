// Copyright Edanoue, Inc. All Rights Reserved.

using System;

namespace Edanoue.VR.Device.Core
{
    public interface IController : ITracker
    {
        /// <summary>
        /// Gets left or right controller.
        /// </summary>
        public ControllerDomain Domain { get; }

        /// <summary>
        /// Gets the primary button (A or X) pressed.
        /// </summary>
        public bool IsPressedPrimary { get; }

        /// <summary>
        /// Gets the primary button (A or X) touched.
        /// </summary>
        public bool IsTouchedPrimary { get; }

        /// <summary>
        /// Gets the secondary button (B or Y) pressed.
        /// </summary>
        public bool IsPressedSecondary { get; }

        /// <summary>
        /// Gets the secondary button (B or Y) touched.
        /// </summary>
        public bool IsTouchedSecondary { get; }

        /// <summary>
        /// Gets the trigger touched.
        /// </summary>
        public bool IsTouchedTrigger { get; }

        /// <summary>
        /// Gets the trigger value. (range: [0.0, 1.0])
        /// </summary>
        public float Trigger { get; }

        /// <summary>
        /// Gets the grip touched.
        /// </summary>
        public bool IsTouchedGrip { get; }

        /// <summary>
        /// Gets the grip value. (range: [0.0, 1.0])
        /// </summary>
        public float Grip { get; }

        /*
        
        // Menu Button
        public string MenuName { get; }
        public bool IsPressedMenu { get; }
        public bool IsTouchedMenu { get; }
        public event Action<bool> PressedMenu;
        public event Action<bool> TouchedMenu;
        
        // System Button
        public string SystemName { get; }
        public bool IsPressedSystem { get; }
        public bool IsTouchedSystem { get; }
        public event Action<bool> PressedSystem;
        public event Action<bool> TouchedSystem;
        */

        /// <summary>
        /// Gets the stick pressed.
        /// </summary>
        public bool IsPressedStick { get; }

        /// <summary>
        /// Gets the stick touched.
        /// </summary>
        public bool IsTouchedStick { get; }

        /// <summary>
        /// Gets the stick X, Y value.
        /// </summary>
        public (float X, float Y) Stick { get; }

        /// <summary>
        /// Gets the thumb rest touched.
        /// Supported Devices:
        /// - Oculus Touch Controller
        /// - Meta Quest Pro Controller
        /// </summary>
        public bool IsTouchedThumbRest { get; }

        /// <summary>
        /// Gets the start button (in-game menu) pressed.
        /// </summary>
        public bool IsPressedStart { get; }

        /// <summary>
        /// Invoke when press or release primary button.
        /// </summary>
        public event Action<bool> PressedPrimary;

        /// <summary>
        /// Invoke when touch or release primary button.
        /// </summary>
        public event Action<bool> TouchedPrimary;

        /// <summary>
        /// Invoke when press or release secondary button.
        /// </summary>
        public event Action<bool> PressedSecondary;

        /// <summary>
        /// Invoke when touch or release secondary button.
        /// </summary>
        public event Action<bool> TouchedSecondary;

        /// <summary>
        /// Invoke when touch or release trigger.
        /// </summary>
        public event Action<bool> TouchedTrigger;

        /// <summary>
        /// Invoke when changed trigger value.
        /// </summary>
        public event Action<float> ChangedTrigger;

        /// <summary>
        /// Invoke when touch or release grip.
        /// </summary>
        public event Action<bool> TouchedGrip;

        /// <summary>
        /// Invoke when changed grip value.
        /// </summary>
        public event Action<float> ChangedGrip;

        /// <summary>
        /// Invoke when touch or release stick.
        /// </summary>
        public event Action<bool> TouchedStick;

        /// <summary>
        /// Invoke when press or release stick.
        /// </summary>
        public event Action<bool> PressedStick;

        /// <summary>
        /// Invoke when changed stick value.
        /// </summary>
        public event Action<float, float> ChangedStick;

        /// <summary>
        /// Invoke when touch or release thumb rest.
        /// </summary>
        public event Action<bool> TouchedThumbRest;

        /// <summary>
        /// Invoke when press or release start (In-Game Menu button).
        /// </summary>
        public event Action<bool> PressedStart;
    }
}