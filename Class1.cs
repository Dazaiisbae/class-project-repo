using System;

public class Class1
{
    public class Vehicle

    {

        //attributes 

        public int VehicleId { get; private set; }

        public string OwnerName { get; private set; }

        public int Currentspeed { get; private set; }

        public bool IsOperational { get; private set; }

        public DateTime DateRegistered { get; private set; }

        //enumerator 

        //for vehicle types 

        public enum VehicleType

        {

            Car,

            Motorcycle,

            Truck

        }

        public VehicleType TypeOfVehicle { get; private set; }

        private List<string> MaintenanceHistory;



        public Vehicle()

        {

            VehicleId = 0;

            OwnerName = "Unknown";

            Currentspeed = 0;

            IsOperational = false;

            DateRegistered = DateTime.Now;

            TypeOfVehicle = VehicleType.Car;

            MaintenanceHistory = new List<string>();

        }

        public Vehicle(int vehicleId, string ownerName, VehicleType vehicleType)

        {

            VehicleId = vehicleId;

            OwnerName = ownerName;

            CurrentSpeed = 0;

            IsOperational = true;

            DateRegistered = DateTime.Now;

            TypeOfVehicle = vehicleType;

            MaintenanceHistory = new List<string>();

        }

        //Methods 

        public virtual void Accelerate(int amount)

        {

            if (!IsOperational) || amount <= 0) 

                    { throw new ArgumentException("Error - vehicle is not operational or invalid acceleration amount"}
            ;

        }



        CurrentSpeed += amount; 

        MaintenanceHistory.add($"Accelerated by {amount} km/h\n{DateTime.Now}"); 

         }



    public virtual void Brake(int amount)

    {

        if (!IsOperational || amount <= 0)

        {

            throw new ArgumentException("Error - Vehicle is not operational or invalid braking amount.");

        }



        CurrentSpeed -= amount;

        if (CurrentSpeed < 0)

            CurrentSpeed = 0;



        MaintenanceHistory.Add($"Braked by {amount} km/h\n{DateTime.Now}");

    }



    public int GetCurrentSpeed()

    {

        return CurrentSpeed;

    }



    public List<string> GetMaintenanceHistory()

    {

        return new List<string>(MaintenanceHistory);

    }



    public override string ToString()

    {

        return $"Vehicle ID: {VehicleId}, Owner: {OwnerName}, Speed: {CurrentSpeed} km/h, Operational: {IsOperational}, Registered: {DateRegistered}, Type: {TypeOfVehicle}";

    }



    public void DisableVehicle()

    {

        IsOperational = false;

        MaintenanceHistory.Add($"Vehicle disabled on {DateTime.Now}");

    }



    public void DisableVehicle(string reason)

    {

        IsOperational = false;

        MaintenanceHistory.Add($"Vehicle disabled on {DateTime.Now}. Reason: {reason}");

    }

} 

} 

 
