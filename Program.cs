using System;

namespace CargoShipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship myCargoShip = new Ship();
            myCargoShip.CycleCount = 8;
            myCargoShip.TrainCarCount = 3;
            Console.WriteLine($"This ship is {myCargoShip.ToString()}");
        }
    }
}
