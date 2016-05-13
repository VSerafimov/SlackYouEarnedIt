using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Description;

namespace SlackYouEarnedIt.Controllers
{
    public class YEIController : ApiController
    {
        [HttpPost]
        [ResponseType(typeof(string))]
        public HttpResponseMessage Post()
        {
            //string data = Request.Content.ReadAsStringAsync().Result;
            string data = "https://clearmeasure.youearnedit.com/slack/authentication";
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage() { Content = new ObjectContent(typeof(string), data, new JsonMediaTypeFormatter()) };

            return httpResponseMessage;
        }
    }
}