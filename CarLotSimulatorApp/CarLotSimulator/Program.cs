﻿using System;
using System.Runtime.Intrinsics.Arm;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {


            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var carLot = new CarLot();

            var ram = new Car();
            {
                ram.Make = "Ram";
                ram.Model = "Laramie";
                ram.Year = 2022;
                ram.EngineNoise = "Vvrrmm";
                ram.HonkNoise = "Beep";
                ram.IsDriveable = true;

                carLot.Cars.Add(ram);

            }

            

            var volvo = new Car();
            {
                volvo.Make = "Volvo";
                volvo.Model = "T6";
                volvo.Year = 2022;
                volvo.EngineNoise = "mmmm";
                volvo.HonkNoise = "Honk";
                volvo.IsDriveable = true;

                carLot.Cars.Add(volvo);
            }

            var nissan = new Car();
            {
                nissan.Make = "Nissan";
                nissan.Model = "Altima";
                nissan.Year = 2022;
                nissan.EngineNoise = "zoom";
                nissan.HonkNoise = "hee hee";
                nissan.IsDriveable = true;

                carLot.Cars.Add(nissan);
            }

            ram.MakeEngineNoise(ram.EngineNoise);
            volvo.MakeEngineNoise(volvo.EngineNoise);
            nissan.MakeEngineNoise(nissan.EngineNoise);

            Console.WriteLine($"Number of cars created {CarLot.numberOfCars}");

            foreach(var car in carLot.Cars)
                   
            {
                Console.WriteLine($"Year {car.Year}, Make {car.Make}, Model {car.Model}");


            }

           

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.


            //At the end iterate through the list printing each of car's Year, Make, and Model to the console



            

            


        }

       
    }
}
