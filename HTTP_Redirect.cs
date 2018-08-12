using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionsLibraryProject
{
    public class HelloHttpTrigger
    {
        public static HttpResponseMessage Run(HttpRequestMessage req, TraceWriter log)
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            var stream = new FileStream(@"d:\home\site\wwwroot\HomePage_Redirect\index.html", FileMode.Open);
            response.Content = new StreamContent(stream);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
            return response;
        }
    }
}