﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.miurl.me")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://www.miurl.me", IsNullable=false)]
public partial class AsientoContable {
    
    private string noAsientoField;
    
    private string descripcionAsientoField;
    
    private System.DateTime fechaAsientoField;
    
    private string cuentaContableField;
    
    private AsientoContableTipoMovimiento tipoMovimientoField;
    
    private decimal montoField;
    
    private string idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="integer")]
    public string NoAsiento {
        get {
            return this.noAsientoField;
        }
        set {
            this.noAsientoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string DescripcionAsiento {
        get {
            return this.descripcionAsientoField;
        }
        set {
            this.descripcionAsientoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="date")]
    public System.DateTime FechaAsiento {
        get {
            return this.fechaAsientoField;
        }
        set {
            this.fechaAsientoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CuentaContable {
        get {
            return this.cuentaContableField;
        }
        set {
            this.cuentaContableField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public AsientoContableTipoMovimiento TipoMovimiento {
        get {
            return this.tipoMovimientoField;
        }
        set {
            this.tipoMovimientoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public decimal Monto {
        get {
            return this.montoField;
        }
        set {
            this.montoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://www.miurl.me")]
public enum AsientoContableTipoMovimiento {
    
    /// <remarks/>
    DB,
    
    /// <remarks/>
    CR,
}
