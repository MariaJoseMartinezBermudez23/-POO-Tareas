using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSystem
{
    public class SmartAirConditioner : ISmartDevice
    {
        public string DeviceId { get; }
        private double _temperature;

        public SmartAirConditioner(string deviceId, double temperature)
        {
            DeviceId = deviceId;
            _temperature = temperature;
        }

        public void TurnOn() => Console.WriteLine($"[Aire Acondicionado {DeviceId}] Climatizando espacio a {_temperature}°C.");
        public void TurnOff() => Console.WriteLine($"[Aire Acondicionado {DeviceId}] Apagado en modo ahorro de energía.");
        public string GetStatus() => $"AC Activo (Temp: {_temperature}°C)";
    }
}
