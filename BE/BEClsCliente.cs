namespace BE
{
    public class BEClsCliente
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Mail { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public BEClsVehiculo Vehiculo { get; set; }
        public BEClsCliente()
        {
            
        }

        public BEClsCliente(int id)
        {
            ID = id;
        }

        public BEClsCliente( string nombre, string apellido, int dni, string fechaNacimiento)
        {
            
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Fecha_Nacimiento = fechaNacimiento;
        }
    }
}