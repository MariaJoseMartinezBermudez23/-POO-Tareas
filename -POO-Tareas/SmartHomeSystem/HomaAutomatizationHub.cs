using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSystem
{
    // Esta clase maneja la política central del sistema. 
    // Nota que NO depende de SmartLight ni SmartAirConditioner, sino de la interfaz ISmartDevice.
    public class HomeAutomationHub
    {
        private readonly List<ISmartDevice> _devices = new List<ISmartDevice>();

        public void RegisterDevice(ISmartDevice device)
        {
            _devices.Add(device);
            Console.WriteLine($"[Hub Central] Dispositivo '{device.DeviceId}' registrado correctamente.");
        }

        public void TriggerEveningRoutine()
        {
            Console.WriteLine("\n--- EJECUTANDO RUTINA NOCTURNA (Bajo Acoplamiento) ---");
            foreach (var device in _devices)
            {
                device.TurnOn();
            }
        }

        public void TriggerShutdownRoutine()
        {
            Console.WriteLine("\n--- APAGANDO SISTEMA GLOBAL ---");
            foreach (var device in _devices)
            {
                device.TurnOff();
            }
        }
    }
}
