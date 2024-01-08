using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSQL
{
    public class Response
    {


        public Response(bool success, string statusMessage, HttpResponseMessage httpResponse = null, string json=null) {
            this.Success = success;
            this.StatusMessage = statusMessage;
            this.HttpResponse = httpResponse;
            this.JSON = json;
        }

        public bool Success { get; set; }
        public string StatusMessage { get; set; }
        public HttpResponseMessage HttpResponse { get; set; }
        public string JSON { get; set; }
        //override public string ToString()
        //{
        //    return "Saját Response létezik";
        //}
    }
    
}
