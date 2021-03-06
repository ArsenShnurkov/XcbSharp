// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 1.1.4322.2032
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace Schemas {
    
    /// <remarks/>
    public class xcb {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(DataType="NCName")]
        public string[] import;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("enum", Type=typeof(@enum))]
        [System.Xml.Serialization.XmlElement("error", Type=typeof(error))]
        [System.Xml.Serialization.XmlElement("errorcopy", Type=typeof(errorcopy))]
        [System.Xml.Serialization.XmlElement("event", Type=typeof(@event))]
        [System.Xml.Serialization.XmlElement("eventcopy", Type=typeof(eventcopy))]
        [System.Xml.Serialization.XmlElement("request", Type=typeof(request))]
        [System.Xml.Serialization.XmlElement("struct", Type=typeof(@struct))]
        [System.Xml.Serialization.XmlElement("typedef", Type=typeof(typedef))]
        [System.Xml.Serialization.XmlElement("union", Type=typeof(union))]
        [System.Xml.Serialization.XmlElement("xidtype", Type=typeof(xidtype))]
        public object[] Items;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute("extension-name", DataType="NCName")]
        public string extensionname;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute("extension-xname", DataType="NCName")]
        public string extensionxname;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string header;
    }
    
    /// <remarks/>
    public class @enum {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement()]
        public item[] item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
    }
    
    /// <remarks/>
    public class item {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("op", Type=typeof(op))]
        [System.Xml.Serialization.XmlElement("value", Type=typeof(string), DataType="NMTOKEN")]
        public object[] Items;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlText()]
        public string[] Text;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
    }
    
    /// <remarks/>
    public class op {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("op")]
        public op op1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(DataType="NCName")]
        public string[] fieldref;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement(DataType="NMTOKEN")]
        public string[] value;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute("op")]
        public string op2;
    }
    
    /// <remarks/>
    public class error {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement()]
        public field[] field;
        
        /// <remarks/>
        public pad pad;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="integer")]
        public string number;
    }
    
    /// <remarks/>
    public class field {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NMTOKEN")]
        public string type;
    }
    
    /// <remarks/>
    public class pad {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="integer")]
        public string byes;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="integer")]
        public string @byte;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="integer")]
        public string bytes;
    }
    
    /// <remarks/>
    public class errorcopy {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="integer")]
        public string number;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string @ref;
    }
    
    /// <remarks/>
    public class @event {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("field", Type=typeof(field))]
        [System.Xml.Serialization.XmlElement("pad", Type=typeof(pad))]
        [System.Xml.Serialization.XmlElement("list", Type=typeof(list))]
        public object[] Items;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute("no-sequence-number")]
        public bool nosequencenumber;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool nosequencenumberSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="integer")]
        public string number;
    }
    
    /// <remarks/>
    public class list {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("fieldref", Type=typeof(string), DataType="NCName")]
        [System.Xml.Serialization.XmlElement("op", Type=typeof(op))]
        [System.Xml.Serialization.XmlElement("value", Type=typeof(string), DataType="NMTOKEN")]
        public object Item;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string type;
    }
    
    /// <remarks/>
    public class eventcopy {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="integer")]
        public string number;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string @ref;
    }
    
    /// <remarks/>
    public class request {
        
        /// <remarks/>
        public exprfield exprfield;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("field", Type=typeof(field))]
        [System.Xml.Serialization.XmlElement("pad", Type=typeof(pad))]
        [System.Xml.Serialization.XmlElement("list", Type=typeof(list))]
        [System.Xml.Serialization.XmlElement("valueparam", Type=typeof(valueparam))]
        public object[] Items;
        
        /// <remarks/>
        public localfield localfield;
        
        /// <remarks/>
        public reply reply;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute("combine-adjacent")]
        public bool combineadjacent;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool combineadjacentSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="integer")]
        public string opcode;
    }
    
    /// <remarks/>
    public class exprfield {
        
        /// <remarks/>
        public op op;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string type;
    }
    
    /// <remarks/>
    public class valueparam {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute("value-list-name", DataType="NCName")]
        public string valuelistname;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute("value-mask-name", DataType="NCName")]
        public string valuemaskname;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute("value-mask-type", DataType="NCName")]
        public string valuemasktype;
    }
    
    /// <remarks/>
    public class localfield {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string type;
    }
    
    /// <remarks/>
    public class reply {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("field", Type=typeof(field))]
        [System.Xml.Serialization.XmlElement("list", Type=typeof(list))]
        [System.Xml.Serialization.XmlElement("pad", Type=typeof(pad))]
        [System.Xml.Serialization.XmlElement("valueparam", Type=typeof(valueparam))]
        public object[] Items;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlText()]
        public string[] Text;
    }
    
    /// <remarks/>
    public class @struct {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("field", Type=typeof(field))]
        [System.Xml.Serialization.XmlElement("list", Type=typeof(list))]
        [System.Xml.Serialization.XmlElement("pad", Type=typeof(pad))]
        public object[] Items;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
    }
    
    /// <remarks/>
    public class typedef {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string newname;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string oldname;
    }
    
    /// <remarks/>
    public class union {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElement("field", Type=typeof(field))]
        [System.Xml.Serialization.XmlElement("list", Type=typeof(list))]
        public object[] Items;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
    }
    
    /// <remarks/>
    public class xidtype {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute(DataType="NCName")]
        public string name;
    }
    
}
