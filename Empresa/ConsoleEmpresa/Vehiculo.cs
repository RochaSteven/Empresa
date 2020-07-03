
namespace ConsoleEmpresa
{
    class Vehiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Color {  get; set; }
        public Cliente Propietario { get; set; }
        public Motor Motor { get; set; }

        public string MostrarMotor()
        {
            return $"Este vehiculo tiene un motor de la marca {Motor.Marca}";
        }

        public string Acelerar()
        {
            return "Pudeo acelerar";
        }
        public string Desacelerar()
        {
            return "Pudeo desacelerar";
        }

    }
}
