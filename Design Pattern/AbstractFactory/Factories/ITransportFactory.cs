﻿using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILandvehicle CreateTransportVehicle();
    }
}
