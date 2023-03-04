﻿using Newtonsoft.Json;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace Adapter.Class.Design.Pattern
{
    /// <summary>
    /// A 'Adapter' class
    /// This is a class that makes two incompatible systems work together. 
    /// The Adapter class implements the Trager interface and provides the implementation for the ServiceA method. 
    /// This class is also composed of the Adaptee i.e. it has a reference to the Adaptee object.
    /// </summary>
    public class EmployeeAdapter : EmployeeManagerAdaptee, IEmployeeTarget
    {
        public string GetAllEmployee()
        {
            string returnXml = GetAllEmpolyees();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(returnXml);
            return JsonConvert.SerializeObject(xmlDocument, Formatting.Indented);
        }
    }
}
