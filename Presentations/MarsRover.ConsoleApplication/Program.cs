using MarsRover.Services.Abstract;
using System;
using MarsRover.Core.Domain;
using MarsRover.Core.Enums;
using MarsRover.Services.Concrete;

namespace MarsRover.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var roverManager = new RoverManager(1, 2, DirectionEnum.N, new Grid(5, 5));
                    Console.WriteLine("Please Write inputs !");
                    var result = roverManager.Operation(Console.ReadLine());
                    Console.WriteLine($"Sonuc:{result}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Hata oluştu !");
                    Console.WriteLine($"Detay:{e.Message}");

                }

            }
        }
    }
}
