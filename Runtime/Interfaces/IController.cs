using System;

namespace Edanoue.VR.Device.Core
{
    public enum ControllerDomain
    {
        Left,
        Right
    }

    public interface IController : ITracker
    {
        /*
        public string ProductName { get; }
        */

        public ControllerDomain Domain { get; }

        // Primary Button (A or X)
        // public string PrimaryName { get; }
        public bool IsPressedPrimary { get; }
        public bool IsTouchedPrimary { get; }

        /*
        
        // Secondary Button (B or Y)
        public string SecondaryName { get; }
        public bool IsPressedSecondary { get; }
        public bool IsTouchedSecondary { get; }
        public event Action<bool> PressedSecondary;
        public event Action<bool> TouchedSecondary;
        
        // Trigger
        public string TriggerName { get; }
        public bool IsTouchedTrigger { get; }
        public float Trigger { get; }
        public event Action<bool> TouchedTrigger;
        public event Action<float> UpdatedTrigger;
        
        // Grip
        public string GripName { get; }
        public bool IsTouchedGrip { get; }
        public float Grip { get; }
        public event Action<bool> TouchedGrip;
        public event Action<float> UpdatedGrip;
        
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

        // Thumb Stick
        // public string StickName { get; }
        public bool IsPressedStick { get; }
        public bool IsTouchedStick { get; }
        public (float X, float Y) Stick { get; }
        public event Action<bool> PressedPrimary;
        public event Action<bool> TouchedPrimary;
        public event Action<bool> TouchedStick;
        public event Action<bool> PressedStick;
        public event Action<float, float> ChangedStick;

        /*
        /// <summary>
        /// Get battery
        /// Return value is [0.0, 1.0] range (1 means Full) 
        /// </summary>
        public float Battery { get; }
        */
    }
}