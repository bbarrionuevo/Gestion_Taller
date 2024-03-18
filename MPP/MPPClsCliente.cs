using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MPP
{
    public class MPPClsCliente
    {
        private XDocument _xmlDocument;
        private string _filePath;
        MPPClsVehiculo MPPVehiculo;

        public MPPClsCliente(string filePath = "clientes.xml")
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);
            MPPVehiculo = new MPPClsVehiculo(); 
            if (!File.Exists(_filePath))
            {
                _xmlDocument = new XDocument(new XElement("Clientes"));
                _xmlDocument.Save(_filePath);
            }
            else
            {
                _xmlDocument = XDocument.Load(_filePath);
            }
        }



        public bool GuardarCliente(BEClsCliente cliente)
        {
            try
            {
                if (_xmlDocument == null)
                {
                    _xmlDocument = new XDocument(new XElement("Clientes"));
                }
                if (cliente.ID != 0)
                {
                    // Si el ID del cliente existe, actualizar el cliente
                    XElement clienteExistente = _xmlDocument.Descendants("Cliente")
                        .Where(c => (int)c.Element("ID") == cliente.ID)
                        .FirstOrDefault();

                    if (clienteExistente != null)
                    {
                        clienteExistente.Element("Nombre").Value = cliente.Nombre;
                        clienteExistente.Element("Apellido").Value = cliente.Apellido;
                        clienteExistente.Element("DNI").Value = cliente.DNI.ToString();
                        clienteExistente.Element("Mail").Value = cliente.Mail;
                        clienteExistente.Element("Fecha_Nacimiento").Value = cliente.Fecha_Nacimiento;
                        clienteExistente.Element("Vehiculo").Value = cliente.Vehiculo.Patente;
                        

                    }
                    else
                    {
                        Console.WriteLine("Cliente con ID " + cliente.ID + " no encontrado.");
                        return false; // Devolver false si el cliente no fue encontrado
                    }
                }
                else
                {
                    // Si el ID del cliente es nulo, agregar un nuevo cliente
                    int nuevoId = ObtenerNuevoId(); // Método para obtener un nuevo ID autoincremental
                    cliente.ID = nuevoId;

                    XElement nuevoCliente = new XElement("Cliente",
                        new XElement("ID", cliente.ID),
                        new XElement("Nombre", cliente.Nombre),
                        new XElement("Apellido", cliente.Apellido),
                        new XElement("DNI", cliente.DNI.ToString()),
                        new XElement("Mail", cliente.Mail),
                        new XElement("Fecha_Nacimiento", cliente.Fecha_Nacimiento),
                        new XElement("Vehiculo", cliente.Vehiculo.Patente)
                    );
                    _xmlDocument.Root.Add(nuevoCliente);
                }

                _xmlDocument.Save(_filePath);
                return true; // Devolver true si el cliente se guardó correctamente
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el cliente: " + ex.Message);
                return false; // Devolver false si hubo un error al guardar el cliente
            }
        }

        private int ObtenerNuevoId()
        {
            try
            {
                List<int> ids = _xmlDocument.Descendants("Cliente")
                    .Select(c => (int)c.Element("ID"))
                    .ToList();

                if (ids.Count == 0)
                {
                    return 1; // Si no hay clientes, el primer ID será 1
                }
                else
                {
                    return ids.Max() + 1; // El nuevo ID será el máximo actual + 1
                }
                
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, registrar el error
                Console.WriteLine("Error al obtener el nuevo ID: " + ex.Message);
                // También podrías lanzar la excepción nuevamente si es necesario
                throw;
            }
        }

        public bool DarDeBajaCliente(BEClsCliente cliente)
        {
            try
            {
                XElement clienteAEliminar = _xmlDocument.Descendants("Cliente")
                    .Where(c => (int)c.Element("ID") == cliente.ID)
                    .FirstOrDefault();

                if (clienteAEliminar != null)
                {
                    clienteAEliminar.Remove();
                    _xmlDocument.Save(_filePath);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción, por ejemplo, registrar el error
                Console.WriteLine("Error al dar de baja al cliente: " + ex.Message);
                return false; // Devolver false si hubo un error al dar de baja al cliente
            }
        }
            public List<BEClsCliente> ObtenerClientes()
            {
            try
            {
                if (_xmlDocument == null)
                {
                    return new List<BEClsCliente>(); // Devolver una lista vacía si el documento es nulo
                }

                List<BEClsCliente> clientes = _xmlDocument.Descendants("Cliente")
                    .Select(cliente => new BEClsCliente
                {
                        ID = (int)cliente.Element("ID"),
                        Nombre = (string)cliente.Element("Nombre"),
                        Apellido = (string)cliente.Element("Apellido"),
                        DNI = (int)cliente.Element("DNI"),
                        Fecha_Nacimiento = (string)cliente.Element("Fecha_Nacimiento"),
                        Mail = (string)cliente.Element("Mail"),
                        Vehiculo = MPPVehiculo.Vehiculo_Por_Patente((string)cliente.Element("Vehiculo"))
                }).ToList();
                return clientes;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los clientes: " + ex.Message);
                return new List<BEClsCliente>(); // Devolver una lista vacía en caso de error
            }
          }
    }
    
}