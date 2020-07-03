namespace ConsoleEmpresa
{
    class Cliente
    {
        
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        
        private Vehiculo vehiculo;
        public Vehiculo Vehiculo 
        {
            get { return vehiculo; } 
            set 
            {
                vehiculo = value;
                vehiculo.Propietario = this;
            } }

      

        public string Comprar ()
        {
            return $"El cliente con el numero de cedeula: {Cedula}\n con el nombre y apellido: {Nombre} {Apellido}\n direccion: {Direccion}\n";
        }

        public string Mostrarvehiculo()
        {
            return $"Se compro el vehiculo {Vehiculo.Modelo}\n de la marca {Vehiculo.Marca}\n de color {Vehiculo.Color}";
        }
       
    }
}
