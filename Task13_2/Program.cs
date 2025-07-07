using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var home = new SmartHomeSystem();
            home.DeviceChanged += (device, status) =>
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] {device}: {status}");
            };
            home.UnLockDoor();
            home.TurnOnLight();
            home.SetTemperature(20);
        }
    }

    public delegate void DeviceStateChanged(string device, string state);
    public class SmartHomeSystem
    {
        public event DeviceStateChanged DeviceChanged;
        bool Light { get; set; }
        int Thermostat { get; set; }
        bool Door { get; set; }

        public SmartHomeSystem()
        {
            Light = false;
            Thermostat = 20;
            Door = false;
        }

        public void TurnOnLight()
        {
            Light = true;
            DeviceChanged?.Invoke("Свет", "Включен");
        }
        public void TurnOffLight()
        {
            Light = false;
            DeviceChanged?.Invoke("Свет", "Выключен");
        }
        public void SetTemperature(int temperature)
        {
            Thermostat = temperature;
            DeviceChanged?.Invoke("Термостат", $"Температура изменена на {temperature}C");
        } 
        public void UnLockDoor()
        {
            Door = true;
            DeviceChanged?.Invoke("Дверь", "Открыта");
        }
        public void LockDoor()
        {
            Door = false;
            DeviceChanged?.Invoke("Дверь", "Закрыта");
        }
    }
}
