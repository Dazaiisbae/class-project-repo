using System;

namespace ClassLibrary

{

    public class Car : Vehicle

    {

        // attributes 

        public int NumberOfDoors { get; private set; }

        public int FuelLevel { get; private set; }

        public bool IsElectric { get; private set; }



        // default constructor 

        public Car() : base()

        {

            NumberOfDoors = 4;

            FuelLevel = 100;

            IsElectric = false;

        }



        // parameterized constructor 

        public Car(int vehicleId, string ownerName, int numberOfDoors, bool isElectric)

            : base(vehicleId, ownerName, VehicleType.Car)

        {

            NumberOfDoors = numberOfDoors;

            FuelLevel = 100;

            IsElectric = isElectric;

        }



        // methods 

        public override void Accelerate(int amount)

        {

            if (FuelLevel <= 0)

            {

                throw new InvalidOperationException("Error - No fuel. Cannot accelerate.");

            }



            base.Accelerate(amount);

            FuelLevel -= amount / 2;



            if (FuelLevel < 0)

                FuelLevel = 0;

        }



        public void Refuel(int amount)

        {

            if (IsElectric)

            {

                throw new InvalidOperationException("Error - Electric cars cannot be refueled.");

            }



            if (amount <= 0)

            {

                throw new ArgumentException("Error - Refuel amount must be positive.");

            }



            FuelLevel += amount;

            if (FuelLevel > 100)

                FuelLevel = 100;

        }



        public void ChargeBattery(int amount)

        {

            if (!IsElectric)

            {

                throw new InvalidOperationException("Error - Gas cars cannot be charged.");

            }



            if (amount <= 0)

            {

                throw new ArgumentException("Error - Charge amount must be positive.");

            }



            FuelLevel += amount;

            if (FuelLevel > 100)

                FuelLevel = 100;

        }



        public override string ToString()

        {

            return base.ToString() +

                   $", Doors: {NumberOfDoors}, Fuel: {FuelLevel}%, Electric: {IsElectric}";

        }

    }

}
