using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Services;

namespace CarService1
{
    public class Car 
    {
        public String make { get; set; }
        public String model { get; set; }
        public String year { get; set; }

      
    }
}