using System;
using System.Collections.Generic;
using System.Text;
using Classes.Enums;

namespace Classes
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }

        public ElectricCar()
        {
            EngineType = EngineType.Electric;
            BatteryCapacity = 100;
        }

        public void Drive(int distance)
        {
            BatteryUsage = (distance * (int)Consumption) / 10;

            int batteryAvailability = BatteryCapacity - BatteryUsage;
            if (batteryAvailability >= 0)
            {
                Console.WriteLine($"You can drive! Battery Usage: {BatteryUsage} %.");
            }
            else
            {
                Console.WriteLine($"The car can not drive. Battery will exceed {BatteryCapacity} %.");
            }
        }

        public void Recharge(int minutes)
        {
            int currentBattery = BatteryCapacity - BatteryUsage;
            int batteryToRecharge = BatteryCapacity - currentBattery;
            int percentOfBatteryRecharged = minutes / 10;

            if(percentOfBatteryRecharged > batteryToRecharge)
            {
                Console.WriteLine($"Can't charge longer than {batteryToRecharge * 10} minutes.");         
            }
            else
            {
                Console.WriteLine($"Your battery have been charged {percentOfBatteryRecharged} %.");
            }
        }
    }
}
