using System;

// Alem dessa classe estar violando o principio OCP, tambem esta violado o SRP, onde em uma mesma classe esta sendo tratado carro e moto
// Essa classe não esta fechada para modificação, pois caso seja necessario efetuar uma mudança em carro ou moto,
// esta afetando uma classe que já esta implementada

// Então a primeira forma de utilizar o principio OCP nesse caso é utilizarmos herança, pois criando uma classe pai,
// com dados comuns entre veiculos, caso seje preciso a criação de um novo tipo de veiculo,
// é possivel extender criando assim uma nova herança dessa classe,
// e não modificando

// Uma outra forma de utilizar o OCP é a utilização de interface
namespace Ocp.Violacao
{

    public class Vehicle
    {
        private string color;
        private int year;
        private double engine;
        private int seats;
        private int doors;

        public Vehicle(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;
        }

        public void Car()
        {
            Console.WriteLine($"Criando um Carro {color}, {year}, {engine}, {seats} assentos e {doors} portas");
            StartVehicle();
        }

        public void Motorcycle()
        {
            Console.WriteLine($"Criando uma Moto {color}, {year}, {engine} cilindradas");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine($"Ligando os motores!");
        }
    }
}
