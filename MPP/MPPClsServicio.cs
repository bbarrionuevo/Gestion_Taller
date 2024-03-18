using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using BE;
using System.IO;


namespace MPP
{
    public class MPPClsServicio
    {

        private XDocument _xmlDocument;
        private string _filePath;
        BEClsServicio BEServicio;
        MPPClsCliente MPPCliente;
        public MPPClsServicio(string filePath = "servicios.xml")
        {
            _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);
            BEServicio = new BEClsServicio();
            MPPCliente = new MPPClsCliente();
            if (!File.Exists(_filePath))
            {
                _xmlDocument = new XDocument(new XElement("Servicios"));
                _xmlDocument.Save(_filePath);
            }
            else
            {
                _xmlDocument = XDocument.Load(_filePath);
            }
        }

        public bool GuardarServicio(BEClsServicio servicio)
        {
            try
            {
                if (_xmlDocument == null)
                {
                    _xmlDocument = new XDocument(new XElement("Servicios"));
                }
                if (servicio.ID != 0)
                {
                    // Si el ID del cliente existe, actualizar el cliente
                    XElement Serv_Exist = _xmlDocument.Descendants("Servicio")
                        .Where(c => (int)c.Element("ID") == servicio.ID)
                        .FirstOrDefault();
                    if (Serv_Exist != null)
                    {
                        Serv_Exist.Element("Fecha").Value = servicio.Fecha;
                        Serv_Exist.Element("Cliente_ID").Value = servicio.Cliente.ID.ToString();
                        Serv_Exist.Element("Aceite_ID").Value = servicio.Aceite.ID.ToString();
                        Serv_Exist.Element("LitrosAceite").Value = servicio.LitrosAceite.ToString();
                        Serv_Exist.Element("Filtro").Value = servicio.Filtro.ToString();
                        Serv_Exist.Element("Precio").Value = servicio.Precio.ToString();


                    }
                    else {
                        Console.WriteLine("Servicio con ID " + servicio.ID + " no encontrado.");
                        return false; // Devolver false si el servicio no fue encontrado}
                    }
                }
                else
                {
                    // Si el ID del servicio es 0, es un nuevo servicio
                    XElement nuevoServicio = new XElement("Servicio",
                    new XElement("ID", ObtenerNuevoId()), // Generar un nuevo ID
                    new XElement("Fecha", servicio.Fecha),
                    new XElement("Cliente_ID", servicio.Cliente.ID),
                    new XElement("Aceite_ID", servicio.Aceite.ID),
                    new XElement("LitrosAceite", servicio.LitrosAceite),
                     new XElement("Filtro", servicio.Filtro.ToString()),
                    new XElement("Precio", servicio.Precio)

                );

                    _xmlDocument.Root.Add(nuevoServicio);
                }

                _xmlDocument.Save(_filePath);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el servicio: " + ex.Message);
                return false;
            }
        }
        private int ObtenerNuevoId()
        {
            try
            {
                List<int> ids = _xmlDocument.Descendants("Servicio")
                    .Select(s => (int)s.Element("ID"))
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
        public bool DarDeBajaServicio(BEClsServicio servicio)
        {
            try
            {

                XElement servicioAEliminar = _xmlDocument.Descendants("Servicio")
                    .Where(s => (int)s.Element("ID") == servicio.ID)
                    .FirstOrDefault();

                if (servicioAEliminar != null)
                {
                    servicioAEliminar.Remove();
                    _xmlDocument.Save(_filePath);
                    return true;
                }
                else
                {
                    Console.WriteLine("ID " + servicio.ID + " no encontrado.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al dar de baja el servicio: " + ex.Message);
                return false;
            }
        }

        public List<BEClsServicio> ObtenerServicios()
        {
            try
            {
                if (_xmlDocument == null)
                {
                    return new List<BEClsServicio>(); // Devolver una lista vacía si el documento es nulo
                }

                List<BEClsServicio> servicios = new List<BEClsServicio>();

                IEnumerable<XElement> elementos = _xmlDocument.Descendants("Servicio");

                foreach (XElement elemento in elementos)
                {
                    BEClsServicio servicio;

                    if (elemento.Element("Filtro").ToString() == "False")
                    {
                        servicio = new BEClsServicio_Premium
                        {
                            ID = (int)elemento.Element("ID"),
                            Fecha = (string)elemento.Element("Fecha"),
                            Cliente = new BEClsCliente((int)elemento.Element("Cliente_ID")),
                            Aceite = ((int)elemento.Element("Aceite_ID") == 1) ? new BEClsSintetico((int)elemento.Element("Aceite_ID")) :
                                    ((int)elemento.Element("Aceite_ID") == 2) ? new BEClsSemiSintetico((int)elemento.Element("Aceite_ID")) : null,
                            LitrosAceite = (int)elemento.Element("LitrosAceite"),
                            Filtro = (bool)elemento.Element("Filtro"),
                            Precio = (double)elemento.Element("Precio")
                        };
                    }
                    else
                    {
                        servicio = new BEClsServicio_Basico
                        {
                            ID = (int)elemento.Element("ID"),
                            Fecha = (string)elemento.Element("Fecha"),
                            Cliente = new BEClsCliente((int)elemento.Element("Cliente_ID")),
                            Aceite = ((int)elemento.Element("Aceite_ID") == 1) ? new BEClsSintetico((int)elemento.Element("Aceite_ID")) :
                                    ((int)elemento.Element("Aceite_ID") == 2) ? new BEClsSemiSintetico((int)elemento.Element("Aceite_ID")) : null,
                            LitrosAceite = (int)elemento.Element("LitrosAceite"),
                            Filtro = (bool)elemento.Element("Filtro"),
                            Precio = (double)elemento.Element("Precio")
                        };
                    }
                    servicios.Add(servicio);
                }
                return servicios;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los servicios: " + ex.Message);
                return new List<BEClsServicio>(); // Devolver una lista vacía en caso de error
            }
            
        }



        public List<BEClsServicio> ObtenerServiciosDeCliente(BEClsCliente BECliente)
        {
            List<BEClsServicio> serviciosCliente = new List<BEClsServicio>();

            try
            {
                if (_xmlDocument == null)
                {
                    _xmlDocument = XDocument.Load(_filePath);
                }

                IEnumerable<XElement> elementos = _xmlDocument.Descendants("Servicio")
                    .Where(s => (int)s.Element("Cliente_ID") == BECliente.ID);

                foreach (XElement elemento in elementos)
                {
                    BEClsServicio servicio;

                    if (elemento.Element("Filtro").ToString() == "False")
                    {
                        servicio = new BEClsServicio_Basico
                        {
                            ID = (int)elemento.Element("ID"),
                            Fecha = (string)elemento.Element("Fecha"),
                            Cliente = BECliente,
                            Aceite = (int)elemento.Element("Aceite_ID") == 1 ? new BEClsSintetico((int)elemento.Element("Aceite_ID")) :
                            ((int)elemento.Element("Aceite_ID") == 2 ? new BEClsSemiSintetico((int)elemento.Element("Aceite_ID")) : null),
                            LitrosAceite = (int)elemento.Element("LitrosAceite"),
                            Filtro = (bool)elemento.Element("Filtro"),
                            Precio = (double)elemento.Element("Precio")
                        };
                    }
                    else
                    {
                        servicio = new BEClsServicio_Premium
                        {
                            ID = (int)elemento.Element("ID"),
                            Fecha = (string)elemento.Element("Fecha"),
                            Cliente = BECliente,
                            Aceite = (int)elemento.Element("Aceite_ID") == 1 ? new BEClsSintetico((int)elemento.Element("Aceite_ID")) :
                            ((int)elemento.Element("Aceite_ID") == 2 ? new BEClsSemiSintetico((int)elemento.Element("Aceite_ID")) : null),
                            LitrosAceite = (int)elemento.Element("LitrosAceite"),
                            Filtro = (bool)elemento.Element("Filtro"),
                            Precio = (double)elemento.Element("Precio")
                        };
                    }

                    serviciosCliente.Add(servicio);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los servicios del cliente: " + ex.Message);
                // Devolver una lista vacía en caso de error
                return new List<BEClsServicio>();
            }

            return serviciosCliente;
        }
    }

}

    

