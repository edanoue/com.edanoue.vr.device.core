namespace Edanoue.VR.Device.Core
{
    public interface ITracker
    {
        public bool IsConnected { get; }

        /*
        public event Action EstablishedConnection;
        public event Action LostConnection;
        */

        public (float X, float Y, float Z) Position { get; }

        public (float W, float X, float Y, float Z) Rotation { get; }

        /*
        public event Action<float, float, float> UpdatedPosition;
        */
    }
}