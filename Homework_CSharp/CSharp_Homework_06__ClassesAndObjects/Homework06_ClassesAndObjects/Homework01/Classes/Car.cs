using System;

namespace Homework01.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed, Driver driver)
        {
            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public int CalculateSpeed()
        {
            int driverSkill = Driver.Skill;
            int carSpeed = Speed;
            int calculatedSpeed = driverSkill + carSpeed;
            return calculatedSpeed;
        }
    }
}
