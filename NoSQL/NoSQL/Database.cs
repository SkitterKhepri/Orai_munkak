using System.Runtime.CompilerServices;
using System.Net.Http;
using System.Data.SqlTypes;

namespace NoSQL
{
    public class Database
    {
        private string url { get;  set; }

        public Database(string url)
        {
            this.url=url;
        }

        public Response Get()
        {
            return new Request(HttpMethod.Get, this.url).Execute();
        }
        public Response Post(string json)
        {
            return new Request(HttpMethod.Get, this.url).Execute();
        }
        public Response Put()
        {
            return new Request(HttpMethod.Get, this.url).Execute();
        }
        public Response Delete()
        {
            return new Request(HttpMethod.Get, this.url).Execute();
        }
    }
}