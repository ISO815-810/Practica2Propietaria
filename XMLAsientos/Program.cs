using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using XMLAsientos.xsd4;

namespace XMLAsientos
{
    class Program
    {
        public static XMLAsientos.Model.AsientoModelContainer db = new XMLAsientos.Model.AsientoModelContainer();
        static void Main(string[] args)
        {
            Menu();
        }

        #region Helpers
        static void Menu()
        {
            Console.WriteLine("\nAsientos\n" +
                              "1 - Ver Asientos.\n" +
                              "2 - Crear Asiento.\n" +
                              "3 - Guardar BD en Archivo.\n" +
                              "4 - Pasar Archivo a BD.\n" +
                              "5 - Quitar.\n");
            Console.Write("Opcion: ");
            var option = Convert.ToInt32(Console.ReadLine());
            HandleOption(option);
        }

        static void HandleOption(int option)
        {
            switch (option)
            {
                case 1:
                    PrintCollection(db.AsientoContableSet);
                    Console.ReadKey();
                    Menu();
                    break;
                case 2:
                    MenuCrearAsiento();
                    Console.ReadKey();
                    Menu();
                    break;
                case 3:
                    MenuGuardarBD();
                    Console.ReadKey();
                    Menu();
                    break;
                case 4:
                    MenuGuardarArchivo();
                    Console.ReadKey();
                    Menu();
                    break;
                case 5:
                    return;
                default:
                    break;
            }
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            var header = new StringBuilder();
            foreach (var prop in collection.GetType().GetGenericArguments()[0].GetProperties())
            {
                header.Append($"{prop.Name,-20}|");
            }
            Console.WriteLine(header.ToString());

            foreach (var item in collection)
            {
                var row = new StringBuilder();
                foreach (var prop in item.GetType().GetProperties())
                {
                    row.Append($"{prop.GetValue(item),-20}|");
                }
                Console.WriteLine(row.ToString());
            }
        }

        public static void MenuCrearAsiento()
        {
            Console.WriteLine("\nNuevo Asiento:\n");
            Console.Write("NoAsiento: ");
            var noAsiento = Convert.ToInt32(Console.ReadLine());
            Console.Write("Descripcion: ");
            var desc = Console.ReadLine();
            Console.Write("Fecha [dd/MM/yyyy]: ");
            var fecha = DateTime.Parse(Console.ReadLine());
            Console.Write("CuentaContable: ");
            var cuenta = Console.ReadLine();
            Console.Write("Tipo [DB | CR]: ");
            var inpTipo = Console.ReadLine();
            var tipo = inpTipo == "DB"
                       ? TipoMovimiento.DB
                       : TipoMovimiento.CR;
            Console.Write("Monto: ");
            var monto = Convert.ToDecimal(Console.ReadLine());

            db.AsientoContableSet.Add(
                new Model.AsientoContable
                {
                    NoAsiento = noAsiento,
                    DescripcionAsiento = desc,
                    FechaAsiento = fecha,
                    CuentaContable = cuenta,
                    TipoMovimiento = tipo,
                    Monto = monto
                }
            );
            db.SaveChanges();
            Console.WriteLine("Se ha guardado con exito el asiento, Sr. Usuario.");
            Console.ReadKey();
        }

        public static void MenuGuardarBD()
        {
            Console.WriteLine("\nGuardar BD en Xml:\n");
            Console.Write("Path / Nombre del archivo: ");
            var filename = Console.ReadLine();
            var asientos = new AsientosContables();
            var asientosContables = from asiento in db.AsientoContableSet
                                    select new XmlAsientoContable
                                    {
                                        Id = asiento.Id.ToString(),
                                        NoAsiento = asiento.NoAsiento.ToString(),
                                        DescripcionAsiento = asiento.DescripcionAsiento,
                                        FechaAsiento = asiento.FechaAsiento,
                                        CuentaContable = asiento.CuentaContable,
                                        TipoMovimiento = asiento.TipoMovimiento,
                                        Monto = asiento.Monto
                                    };

            asientos.AsientoContable = asientosContables.ToList();
            asientos.SaveToXmlFile(filename);

            Console.WriteLine("Se guardo el xml con exito, Sr. Usuario! :v");
        }

        public static void MenuGuardarArchivo()
        {
            Console.WriteLine("\nGuardar Xml en BD:\n");
            Console.Write("Path / Nombre del archivo: ");
            var filename = Console.ReadLine();
            var asientos = ParseXmlAsientos(filename);
            foreach (var asiento in asientos.AsientoContable)
            {
                db.AsientoContableSet.Add(ConvertAsientosToModel(asiento));
            }
            db.SaveChanges();
            Console.WriteLine("Se ha guardado con exito en la BD, Sr. Usuario.");
            Console.ReadKey();
        }
        #endregion

        public static T ParseXml<T>(string filename)
        {
            var ser = new XmlSerializer(typeof(T));
            var fs = new FileStream(filename, FileMode.Open);
            return (T) ser.Deserialize(fs);
        }

        public static AsientosContables ParseXmlAsientos(string filename) => ParseXml<AsientosContables>(filename);

        #region Convertir entre modelos
        public static Model.AsientoContable ConvertAsientosToModel(XmlAsientoContable asiento)
        {
            return new Model.AsientoContable
            {
                NoAsiento = Convert.ToInt32(asiento.NoAsiento),
                DescripcionAsiento = asiento.DescripcionAsiento,
                FechaAsiento = asiento.FechaAsiento,
                CuentaContable = asiento.CuentaContable,
                TipoMovimiento = asiento.TipoMovimiento,
                Monto = asiento.Monto,
            };
        }

        public static XmlAsientoContable ConvertModelToAsientos(Model.AsientoContable asiento)
        {
            return new XmlAsientoContable
            {
                Id = asiento.Id.ToString(),
                NoAsiento = asiento.NoAsiento.ToString(),
                DescripcionAsiento = asiento.DescripcionAsiento,
                FechaAsiento = asiento.FechaAsiento,
                CuentaContable = asiento.CuentaContable,
                TipoMovimiento = asiento.TipoMovimiento,
                Monto = asiento.Monto
            };
        }
        #endregion
    }

    public static class XmlAsientosExtension
    {
        public static void SaveToXmlFile(this XMLAsientos.xsd4.AsientosContables asientos, string filename="asientos_new.xml")
        {
            var ser = new XmlSerializer(typeof(AsientosContables));
            using(var xml_writer = XmlWriter.Create(filename))
            {
                ser.Serialize(xml_writer, asientos);
            }
        }
    }    

}
