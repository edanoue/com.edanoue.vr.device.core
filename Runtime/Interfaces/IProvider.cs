namespace Edanoue.VR.Device.Core
{
    public interface IProvider
    {
        public string FamilyName { get; }
        public string ProductName { get; }
        public string Version { get; }
        
        public IHeadset Headset { get; }
        public IController LeftController { get; }
        public IController RightController { get; }
    }
}