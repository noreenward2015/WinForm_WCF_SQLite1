using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebGet]
        string GetDataUsingMethodName(string value);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetData/{value}")]
        string GetDataUsingURI(string value);

        [OperationContract]
        [WebGet(UriTemplate = "/GetImage")]
        Stream GetImage();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/GetCarById/{value}")]
        string GetCarById(string value);
       
      



    }   
}
