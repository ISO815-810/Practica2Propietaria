using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace XMLAsientos.xsd4
{
    [XmlRoot(ElementName = "AsientoContable", Namespace = "https://www.miurl.me")]
    public class XmlAsientoContable
    {
        [XmlElement(ElementName = "NoAsiento", Namespace = "https://www.miurl.me", DataType = "integer")]
        public string NoAsiento { get; set; }

        [XmlElement(ElementName = "DescripcionAsiento", Namespace = "https://www.miurl.me")]
        public string DescripcionAsiento { get; set; }        

        //[XmlElement(ElementName = "FechaAsiento", Namespace = "https://www.miurl.me",
        //    Form = System.Xml.Schema.XmlSchemaForm.Unqualified
        //    )]//,DataType = "date")]
        //public DateTime FechaAsiento { get; set; }

        [XmlIgnore]
        public DateTime FechaAsiento { get; set; }

        [XmlElement(ElementName = "FechaAsiento")]
        public string ProxyFechaAsiento
        {
            get { return FechaAsiento.ToString("dd/MM/yyyy"); }
            set { FechaAsiento = DateTime.Parse(value); }
        }

        [XmlElement(ElementName = "CuentaContable", Namespace = "https://www.miurl.me")]
        public string CuentaContable { get; set; }

        [XmlElement(ElementName = "TipoMovimiento", Namespace = "https://www.miurl.me")]
        public TipoMovimiento TipoMovimiento { get; set; }

        [XmlElement(ElementName = "Monto", Namespace = "https://www.miurl.me")]
        public decimal Monto { get; set; }

        [XmlAttribute(AttributeName = "Id", DataType = "integer")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "AsientosContables", Namespace = "https://www.miurl.me")]
    public class AsientosContables
    {
        [XmlElement(ElementName = "AsientoContable", Namespace = "https://www.miurl.me")]
        public List<XmlAsientoContable> AsientoContable { get; set; }        
    }

    [Serializable]
    [XmlType(AnonymousType = true, Namespace = "https://www.miurl.me")]
    public enum TipoMovimiento { DB, CR }
}
