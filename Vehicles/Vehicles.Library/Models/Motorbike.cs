﻿using System;
using Vehicles.Library.Abstractions;
using Vehicles.Library.Interfaces;
using Vehicles.Library.Strategies.MoveStrategy;

namespace Vehicles.Library.Models
{
    public class Motorbike : Vehicle, ILandcraftVehicle
    {
        public Motorbike()
        {
            MovingType = new DriveStrategy();
        }

        public override void Move<TStrategy>()
        {
            MovingType = new TStrategy();
            Console.WriteLine("Motorbike sound");
        }
    }
}
