using System;

namespace SmartHomeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeAutomationHub smartHub = new HomeAutomationHub();


            ISmartDevice salaLuz = new SmartLight("LIVING_ROOM_01", 75);
            ISmartDevice oficinaAC = new SmartAirConditioner("OFFICE_AC_02", 21.5);

            smartHub.RegisterDevice(salaLuz);
            smartHub.RegisterDevice(oficinaAC);


            smartHub.TriggerEveningRoutine();
            smartHub.TriggerShutdownRoutine();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

// ENLACE JUEGO: https://dashboard.blooket.com/set/6ab6d7922eef34092c9631d4
