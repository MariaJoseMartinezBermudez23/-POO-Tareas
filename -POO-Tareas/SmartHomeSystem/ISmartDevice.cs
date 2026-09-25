using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSystem
{

    public interface ISmartDevice
    {
        string DeviceId { get; }
        void TurnOn();
        void TurnOff();
        string GetStatus();
    }
}
