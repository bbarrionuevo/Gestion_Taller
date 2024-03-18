using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MPP
{
    public class MPPClsVehiculo
    {
        private XDocument _xmlDocument;
        private string _filePath;

        public MPPClsVehiculo(string filePath = "vehiculos.xml")
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);

            if (!File.Exists(_filePath))
            {
                _xmlDocument = new XDocument(new XElement("Vehiculos"));
                _xmlDocument.Save(_filePath);
            }
            else
            {
                _xmlDocument = XDocument.Load(_filePath);
            }
        }

        public bool Guardar(BEClsVehiculo vehiculo)
        {
            try
            {
                if (_xmlDocument == null)
                {
                    _xmlDocument = new XDocument(new XElement("Vehiculos"));
                }



                XElement nuevoVehiculo = new XElement("Vehiculo",

                    new XElement("Marca", vehiculo.Marca),
                    new XElement("Modelo", vehiculo.Modelo),
                    new XElement("Patente", vehiculo.Patente),
                    new XElement("Kilometraje", vehiculo.Kilometraje),
                    new XElement("Categoria", vehiculo.Categoria)
                );

                _xmlDocument.Root.Add(nuevoVehiculo);
                _xmlDocument.Save(_filePath);

                return true; // Devolver true si el vehículo se guardó correctamente
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el vehículo: " + ex.Message);
                return false; // Devolver false si hubo un error al guardar el vehículo
            }
        }

        public List<BEClsVehiculo> ObtenerVehiculos()
        {
            try
            {
                if (_xmlDocument == null)
                {
                    return new List<BEClsVehiculo>(); // Devolver una lista vacía si el documento es nulo
                }

                List<BEClsVehiculo> vehiculos = _xmlDocument.Descendants("Vehiculo")
                    .Select(v => new BEClsVehiculo
                    {

                        Marca = (string)v.Element("Marca"),
                        Modelo = (string)v.Element("Modelo"),
                        Patente = (string)v.Element("Patente"),
                        Kilometraje = (int)v.Element("Kilometraje"),
                        Categoria = (string)v.Element("Categoria")
                    })
                    .ToList();

                return vehiculos;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener vehículos: " + ex.Message);
                return new List<BEClsVehiculo>(); // Devolver una lista vacía si hubo un error al obtener los vehículos
            }
        }
        public BEClsVehiculo Vehiculo_Por_Patente(string patente) 
        {
            try
            {
                if (_xmlDocument == null)
                {
                    return null;
                }

                XElement vehiculo = _xmlDocument.Descendants("Vehiculo")
                    .FirstOrDefault(v => (string)v.Element("Patente") == patente);

                if (vehiculo != null)
                {
                    BEClsVehiculo vehiculoEncontrado = new BEClsVehiculo
                    {
                        
                        Marca = (string)vehiculo.Element("Marca"),
                        Modelo = (string)vehiculo.Element("Modelo"),
                        Patente = (string)vehiculo.Element("Patente"),
                        Kilometraje = (int)vehiculo.Element("Kilometraje"),
                        Categoria = (string)vehiculo.Element("Categoria")
                    };

                    return vehiculoEncontrado;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener vehículo por patente: " + ex.Message);
                return null;
            }
        }

    }
    }
