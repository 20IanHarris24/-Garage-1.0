using Assignment_5___Garage_1._0;
using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

internal class Program
{
   
    public static void Main(string[] args)
    {



        //Ask for size
        
        Console.WriteLine("\n\tWelcome to the Garage application.");
        Console.WriteLine("\n\tEnter number of parking spaces for your garage: ");
        
        int size = Int32.Parse(Console.ReadLine()!);                        //accept user input -- No input check implemented yet
       
        //while(true)
        // { 
        //    char size = ' '; //Creates the character input to be used with the switch-case below.
        //    try
        //    {
        //        size = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
        //    }
        //    catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
        //    {
        //        Console.Clear();
        //        Console.WriteLine("Please enter a valid input!");
        //    }
        //}


        //Create instance of a Garage (garageHandler) 
        IHandler testGarage = new GarageHandler(size);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n\t The Garage has been built and contains {size} spaces");
        Console.ResetColor();
        //Create main menu (test)
        {

            while (true)
            {
                Console.WriteLine("\nPlease navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice\n"
                    + "\n\t1. Fill the Garage"
                    + "\n\t2. Work in progress"
                    + "\n\t3. Work in progress"
                    + "\n\t4. Work in progress"
                    + "\n\t0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("\nPlease enter an input!");
                }
                switch (input)
                {
                    case '1':

                        SeedVehicles();
                        DisplayVehiclesInGarage();
                        break;
                    /*case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParenthesis();
                        break;*/
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }





        //Switch for different options
        //var dummyInput = "1";


        //switch (dummyInput)
        //{
        //    case "1":
        //        SeedVehicles();
        //        break;
        //    default:
        //        break;
        //}
        //1. Seed



        //Car car = new(0, "Car", "Electric", VehicleColour.Black, 4);
        //Motorcycle motorcycle = new(2, "Motorcycle", "Petrol", VehicleColour.Green, 3);
        //Airplane airplane = new(4, "Plane", "Jet", VehicleColour.White, 10);
        //Bus bus = new(50, "Bus", "Diesel", VehicleColour.Blue, 6);
        //Boat boat = new(5.68, "Boat", "Diesel", VehicleColour.Brown, 0);


        //Vehicle.DisplayVehicleDetails(car);
        //Vehicle.DisplayVehicleDetails(motorcycle);
        //Vehicle.DisplayVehicleDetails(airplane);
        //Vehicle.DisplayVehicleDetails(bus);
        //Vehicle.DisplayVehicleDetails(boat);



        //success = testGarage.Park(car);
        //Console.WriteLine($"vehicle parked or not: {success}");
        //success = testGarage.Park(airplane);
        //Console.WriteLine($"vehicle parked or not: {success}");
        //success = testGarage.Park(bus);
        //Console.WriteLine($"vehicle parked or not: {success}");
        //success = testGarage.Park(motorcycle);
        //Console.WriteLine($"vehicle parked or not: {success}");
        ////success = testGarage.Leave(bus);
        ////Console.WriteLine($"vehicle unparked or not: {success}");
        //success = testGarage.Park(boat);
        //Console.WriteLine($"vehicle parked or not: {success}");



        //Console.WriteLine(GenerateRegNum.GenerateRandomRegNum());

        //airplane.VehicleColour = VehicleColour.Green;





        void SeedVehicles()
        {
            bool success = false;
            do
            {
                foreach (var vehicle in testGarage.VGarage)
                {
                    success = testGarage.Park(new Car(0, "Car", "Electric", VehicleColour.Black, 4));
                    success = testGarage.Park(new Motorcycle(2, "Motorcycle", "Petrol", VehicleColour.Green, 3));

                    if (success == false)
                    {
                        break;
                    }


                    //testGarage.Park(new Airplane(4, "Plane", "Jet", VehicleColour.White, 10));
                    //testGarage.Park(new Bus(50, "Bus", "Diesel", VehicleColour.Blue, 6));
                    //testGarage.Park(new Boat(5.68, "Boat", "Diesel", VehicleColour.Brown, 0));
                }

            }
            while (success == true);

       

            Console.WriteLine("The Garage is Full");
        }

        //Display Vehicles in garage

        void DisplayVehiclesInGarage()
        {
        var What_is_it = testGarage.GetVehicles();
            
            foreach (var vehicle in What_is_it)
            {
                testGarage.DisplayVehicleDetails(vehicle);
            }



        }
        //testGarage.DisplayVehicleDetails(What_is_it);
        //testGarage.VGarage.VehicleGarage.DisplayVehicleDetails(car);
        //Vehicle.DisplayVehicleDetails(motorcycle);
        //Vehicle.DisplayVehicleDetails(airplane);
        //Vehicle.DisplayVehicleDetails(bus);
        //Vehicle.DisplayVehicleDetails(boat);

        //success = testGarage.Park(car);
        //Console.WriteLine($"vehicle parked or not: {success}");
        //success = testGarage.Park(airplane);
        //Console.WriteLine($"vehicle parked or not: {success}");
        //success = testGarage.Park(bus);
        //Console.WriteLine($"vehicle parked or not: {success}");
        //success = testGarage.Park(motorcycle);
        //Console.WriteLine($"vehicle parked or not: {success}");
        //success = testGarage.Leave(What_is_it is Car);
        //Console.WriteLine($"vehicle unparked or not: {success}");
        //success = testGarage.Park(boat);
        //Console.WriteLine($"vehicle parked or not: {success}");




    }


} 