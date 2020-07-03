using System;

namespace ConsoleEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            var empresa = new Empresa();
            empresa.Id = new Random().Next();
            empresa.Nombre = "Chevrolet";
            empresa.Propietario = "Ing. Alex Paul";
            
            var cliente = new Cliente
            {
                Id = new Random().Next(),
                Cedula = "1734567890",
                Nombre = "Steven",
                Apellido = "Rocha",
                Direccion = "terminal quitumbe"
            };

           
            var carro = new Vehiculo
            {
                Id = new Random().Next(),
                Marca = "Chevrolet",
                Modelo = "Aveo family"
            };


            cliente.Vehiculo=carro;

            Motor motor = new Motor
            {
                Id = new Random().Next(),
                Marca = "Nitrux12",
                TipoDeMotor = "Electrico"
            };
            carro.Motor = motor;
      
            Console.Write(cliente.Comprar());
            Console.WriteLine(cliente.Mostrarvehiculo());
            Console.WriteLine(carro.MostrarMotor());
            
            Console.ReadKey();
        }
    }
}
