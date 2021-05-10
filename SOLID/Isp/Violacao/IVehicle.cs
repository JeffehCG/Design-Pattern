using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Pode ser identificado uma violação no principio Isp nessa interface, 
// pois visualizamos metodos que não teram a necessidade de serem implementados em todas situações
// Criando a classe "Car" o metodo ConfigureMotorcycle() não sera utilizado pelo mesmo
// Porem o contrato exige que esse metodo seja implementado
namespace Isp.Violacao
{
    interface IVehicle
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
        void ConfigureMotorcycle(string color, int year, double engine);
        void StartVehicle();
    }
}
