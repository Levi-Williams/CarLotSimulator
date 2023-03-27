using System;
using System.Collections.Generic;

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

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            //START CODE//

            List<Car> Cars = new List<Car>();

            //Car 1//

            Car chevy= new Car();
            chevy.Make = "Chevrolet";
            chevy.Year = 2016;
            chevy.Model = "Malibu";
            chevy.EngineNoise = "Burr";
            chevy.HonkNoise = "high beep";

            chevy.MakeEngineNoise(chevy.EngineNoise);
            chevy.MakeHonkNoise(chevy.HonkNoise);

            Cars.Add(chevy);

            Console.WriteLine(CarLot.numberOfCars);

            //Car 2//

            Car ford = new Car() { Make = "Ford", Year = 2015, Model = "Focus", EngineNoise = "Clank", HonkNoise = "boop" };

            ford.MakeEngineNoise(ford.EngineNoise);

            ford.MakeHonkNoise(ford.HonkNoise);

            Cars.Add(ford);

            Console.WriteLine(CarLot.numberOfCars);

            //Car 3//

            Car toyota = new Car(2020, "Toyota", "Corolla", "clunk", "bleep", true);

            toyota.MakeHonkNoise(toyota.HonkNoise);

            toyota.MakeEngineNoise(toyota.EngineNoise);

            Cars.Add(toyota);

            Console.WriteLine(CarLot.numberOfCars);


            foreach (var Car in Cars) { Console.WriteLine($" Make: {Car.Make}, Year: {Car.Year}, Model: {Car.Model}, Engine Noise Description: {Car.EngineNoise}, Honk Noise Description: {Car.HonkNoise} "); }

            

        }
    }
}
