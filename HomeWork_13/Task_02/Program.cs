// Реализуйте систему управления умным домом на C# с использованием событий.
// Система должна отслеживать изменения состояния устройств и уведомлять пользователя о важных событиях.

// 1. Класс SmartHomeSystem
// Должен содержать:
//    Список подключенных устройств (например, свет, термостат, дверные датчики)
//    Методы для управления устройствами:
//        TurnOnLight() / TurnOffLight()
//        SetTemperature(int newTemp)
//        LockDoor() / UnlockDoor()
//    Событие DeviceStateChanged, срабатывающее при изменении состояния любого устройства.

// 2. Событие DeviceStateChanged
// Должно передавать:
//    Тип устройства ("Light", "Thermostat", "Door")
//    Новое состояние (например, "On", "Off", "Locked", "Temperature set to 25°C")
//    Время изменения.

// 3. Подписка на события в Main

// Пример лога при работе программы:
// [14:30:00] Light: Включен
// [14:31:15] Thermostat: Температура изменена на 23°C
// [14:35:40] Door: Заблокирована

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var smartHome = new SmartHomeSystem();

            // Подписываемся на событие
            smartHome.DeviceStateChanged += (sender, e) =>
            {
                Console.WriteLine($"[{e.ChangeTime.ToString("HH:mm:ss")}] {e.DeviceType}: {e.NewState}");
            };

            // Демонстрация работы
            smartHome.TurnOnLight();
            smartHome.SetTemperature(23);
            smartHome.UnlockDoor();
            smartHome.LockDoor();
            smartHome.TurnOffLight();
        }
    }

    // Класс для аргументов события
    public class DeviceEventArgs : EventArgs
    {
        public string DeviceType { get; }
        public string NewState { get; }
        public DateTime ChangeTime { get; }

        public DeviceEventArgs(string deviceType, string newState)
        {
            DeviceType = deviceType;
            NewState = newState;
            ChangeTime = DateTime.Now;
        }
    }

    // Класс умного дома
    public class SmartHomeSystem
    {
        private bool _lightOn;
        private int _temperature = 20;
        private bool _doorLocked = true;

        // Событие изменения состояния
        // EventHandler - стандартный делегат для событий в .NET.
        // Он имеет такое определение:
        // delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e)
        // Соответствующий метод должен не возвращать значение (void) и иметь два аргумента:
        //     object? sender (обычно this - объект, вызвавший событие);
        //     TEventArgs e - детали изменения
        public event EventHandler<DeviceEventArgs> DeviceStateChanged;

        // Методы управления
        public void TurnOnLight()
        {
            _lightOn = true;
            OnDeviceStateChanged("Light", "Включен");
        }

        public void TurnOffLight()
        {
            _lightOn = false;
            OnDeviceStateChanged("Light", "Выключен");
        }

        public void SetTemperature(int newTemp)
        {
            _temperature = newTemp;
            OnDeviceStateChanged("Thermostat", $"Температура изменена на {newTemp}°C");
        }

        public void LockDoor()
        {
            _doorLocked = true;
            OnDeviceStateChanged("Door", "Заблокирована");
        }

        public void UnlockDoor()
        {
            _doorLocked = false;
            OnDeviceStateChanged("Door", "Разблокирована");
        }

        // Метод для генерации события
        protected virtual void OnDeviceStateChanged(string deviceType, string newState)
        {
            DeviceStateChanged?.Invoke(this, new DeviceEventArgs(deviceType, newState));
        }
    }
}
