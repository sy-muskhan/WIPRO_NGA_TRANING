using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Programs
{
    internal class Program4_CarParking//camelcasing is used for naming the class
    {
        //Step 1: Initialize parking with the help of for loop
        //Step 2: parking vehicles
        //Step 3: exit vehicles
        //Step 4: calculate charges based on vehicle type
        //Step 5: Keeping the application running until the user exits.
        int totalSpots = 10;
            bool[] parkingSlots;

            public Program4_CarParking()
            {
                parkingSlots = new bool[totalSpots];
            }

            public static void Main(string[] args)
            {
                Program4_CarParking obj = new Program4_CarParking();
                obj.Run();
            }

            void Run()
            {
                int choice;
                do
                {
                    Console.WriteLine("Car Parking System");
                    Console.WriteLine("1. Park Vehicle");
                    Console.WriteLine("2. Exit Vehicle");
                    Console.WriteLine("3. Exit Application");
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            ParkVehicle();
                            break;
                        case 2:
                            ExitVehicle();
                            break;
                        case 3:
                            Console.WriteLine("Exiting Application");
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                } while (choice != 3);
            }

            void ParkVehicle()
            {
                for (int i = 0; i < totalSpots; i++)
                {
                    if (!parkingSlots[i])
                    {
                        parkingSlots[i] = true;
                        Console.WriteLine($"Vehicle parked at spot {i + 1}");
                        return;
                    }
                }
                Console.WriteLine("Parking Full");
            }

            void ExitVehicle()
            {
                Console.Write("Enter parking spot number to exit: ");
                int spot = Convert.ToInt32(Console.ReadLine());

                if (spot < 1 || spot > totalSpots || !parkingSlots[spot - 1])
                {
                    Console.WriteLine("Invalid spot number");
                    return;
                }

                parkingSlots[spot - 1] = false;
                Console.WriteLine($"Vehicle exited from spot {spot}");
            }
        }
    }

