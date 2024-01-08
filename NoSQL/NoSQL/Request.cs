
namespace NoSQL
{
    using System.Net.Http;
    using System.Text;

    public class Request
    {

        private HttpMethod Method { get; set; }
        private string Url { get; set; }
        private string JSON { get; set; }

        public Request(HttpMethod method, string url, string json = null){

            this.Method = method;
            this.Url = url;

        }
        public Response Execute() {

            Response response = null;
            HttpClient client = new HttpClient();
            HttpRequestMessage message = new HttpRequestMessage(this.Method, this.Url);
            if(this.JSON != null)
            {
                message.Content = new StringContent(
                    this.JSON,
                    UnicodeEncoding.UTF8,
                    "application/json"
                    );
            }
            Task<HttpResponseMessage> result = client.SendAsync(message);
            response = new Response(
                result.Result.IsSuccessStatusCode,
                $"{result.Result.StatusCode}: {result.Result.ReasonPhrase}",
                result.Result,
                $"{this.JSON}"
                );


            return response;

        }
    }
}
