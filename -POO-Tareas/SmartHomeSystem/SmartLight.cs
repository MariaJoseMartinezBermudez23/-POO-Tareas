using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSystem
{
    public class SmartLight : ISmartDevice
    {
        public string DeviceId { get; }
        private int _brightness;

        public SmartLight(string deviceId, int brightness)
        {
            DeviceId = deviceId;
            _brightness = brightness;
        }

        public void TurnOn() => Console.WriteLine($"[Luz Inteligente {DeviceId}] Encendida al {_brightness}% de intensidad.");
        public void TurnOff() => Console.WriteLine($"[Luz Inteligente {DeviceId}] Apagada.");
        public string GetStatus() => $"Luz Activa (Brillo: {_brightness}%)";
    }
}
