using System;

namespace ClassLibrary

{

    public class Motorcycle : Vehicle

    {

        // attributes 

        public bool HasSidecar { get; private set; }

        public int FuelLevel { get; private set; }



        // default constructor 

        public Motorcycle() : base()

        {

            HasSidecar = false;

            FuelLevel = 100;

        }



        // parameterized constructor 

        public Motorcycle(int vehicleId, string ownerName, bool hasSidecar)

            : base(vehicleId, ownerName, VehicleType.Motorcycle)

        {

            HasSidecar = hasSidecar;

            FuelLevel = 100;

        }



        // methods 

        public override void Accelerate(int amount)

        {

            if (FuelLevel <= 0)

            {

                throw new InvalidOperationException("Error - No fuel. Cannot accelerate.");

            }



            // motorcycles accelerate faster than other vehicles 

            int boostedAmount = amount * 2;



            base.Accelerate(boostedAmount);



            FuelLevel -= amount;



            if (FuelLevel < 0)

                FuelLevel = 0;

        }



        public void Refuel(int amount)

        {

            if (amount <= 0)
