using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Ride ride1 = new Ride("Amit Verma", "Rohan Singh", 10);
            Ride ride2 = new Ride("Priya Nair", "Anjali Gupta", 5);
            Ride ride3 = new Ride("Karan Malhotra", "Neha Sharma", 12);

            ride1.ShowRideDetails();
            ride2.ShowRideDetails();
            ride3.ShowRideDetails();

            Ride.ShowRideSummary();
        }
    }
    public class Ride
    {
        
        public static int totalRides {  get; set; }
        public static double totalEarnings { get; set; }    
        public static double baseFare { get; set; }
        public static double surgeMultiplier { get; set; } 
        public static int counter = 1000;

        public string RideId { get; set; }
        public string DriverName { get; set; }
        public string PassengerName { get; set; }
        public double DistanceKm { get; set; }
        public double Fare { get; set; }


        static Ride() {
            totalRides = 0;
            totalEarnings = 0;
            surgeMultiplier = 1.0;
            baseFare = 50;
            Console.WriteLine("Uber System Initialized. Ready to book rides...");
        }

        public Ride(string driverName, string passengerName, double distanceKm)
        {
            totalRides++;
            counter++;
            RideId = $"Ride_{counter}";
            DriverName = driverName ;   
            PassengerName = passengerName ;
            DistanceKm = distanceKm ;

            Fare = FareCalculation(distanceKm);
            totalEarnings = totalEarnings + Fare;
        }

        public double FareCalculation(double distanceKm)
        {
            return baseFare + (distanceKm * 15 * surgeMultiplier);
        }

        public static void SergeMultiplier(double multiplier)
        {
            surgeMultiplier = multiplier;
        }

        public static void ShowRideSummary()
        {
            Console.WriteLine("Total Rides : "+ totalRides);
            Console.WriteLine("Total Earnings : "+ totalEarnings);
        }

        public void ShowRideDetails()
        {
            Console.WriteLine($"Ride Id {RideId}, Driver {DriverName}, Passanger {PassengerName}, Distance {DistanceKm}, Fare {Fare}");
        }
    }
}
